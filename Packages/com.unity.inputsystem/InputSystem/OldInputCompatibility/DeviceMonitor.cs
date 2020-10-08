using System;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem.OldInputCompatibility
{
    // Helper class to add device usage to devices as they come and go.
    internal static class DeviceMonitor
    {
        private static int m_JoystickCount;
        private static InputDevice[] m_Joysticks;
        private static Action<char> m_KeyboardOnText;

        public static string JoyNumToUsage(int joyNum)
        {
            return $"LegacyJoystick{joyNum}";
        }

        private static void OnDeviceAdd(InputDevice device)
        {
            switch (device)
            {
                case Joystick _:
                case Gamepad _:
                {
                    var index = ArrayHelpers.AppendWithCapacity(ref m_Joysticks, ref m_JoystickCount,
                        device);
                    InputSystem.AddDeviceUsage(device, JoyNumToUsage(index));
                    break;
                }
                case Keyboard keyboard:
                    keyboard.onTextInput += m_KeyboardOnText;
                    break;
            }
        }

        private static void OnDeviceRemoved(InputDevice device)
        {
            switch (device)
            {
                case Joystick _:
                case Gamepad _:
                {
                    var index = m_Joysticks.IndexOfReference(device);
                    if (index != -1)
                    {
                        ArrayHelpers.EraseAtWithCapacity(m_Joysticks, ref m_JoystickCount, index);
                        InputSystem.RemoveDeviceUsage(device, JoyNumToUsage(index));
                    }

                    break;
                }
                case Keyboard keyboard:
                    keyboard.onTextInput -= m_KeyboardOnText;
                    break;
            }
        }

        public static void Enable(Action<char> keyboardOnText)
        {
            m_KeyboardOnText = keyboardOnText;

            // Collect all joysticks and gamepads.
            foreach (var device in InputSystem.devices)
                OnDeviceAdd(device);

            // Monitor joysticks and gamepads.
            InputSystem.onDeviceChange +=
                (device, change) =>
                {
                    if (change == InputDeviceChange.Removed)
                        OnDeviceAdd(device);
                    else if (change == InputDeviceChange.Added)
                        OnDeviceRemoved(device);
                };
        }
    };
}