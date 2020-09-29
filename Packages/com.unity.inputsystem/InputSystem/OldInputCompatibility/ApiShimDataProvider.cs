using System;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.InputSystem.OldInputCompatibility
{
    internal class ApiShimDataProvider : Input.DataProvider
    {
        public ApiShimDataProvider(
            InputActionMap setMap,
            ActionStateListener setAnyKeyStateListener,
            IDictionary<string, ActionStateListener> setStateListeners,
            ActionStateListener[] setKeyActions
            )
        {
            map = setMap;
            anyKeyStateListener = setAnyKeyStateListener;
            stateListeners = setStateListeners;
            keyActions = setKeyActions;
        }

        private InputActionMap map;
        private ActionStateListener anyKeyStateListener;
        private IDictionary<string, ActionStateListener> stateListeners; // TODO remove this later on
        private ActionStateListener[] keyActions; // array of keycodes

        public override float GetAxis(string axisName)
        {
            // TODO maybe axisName == actionName is not the best
            return map.FindAction(axisName)?.ReadValue<float>() ?? 0.0f;
        }

        public override bool GetButton(string axisName)
        {
            return stateListeners.TryGetValue(axisName, out var listener) && listener.isPressed;
        }

        public override bool GetButtonDown(string axisName)
        {
            return stateListeners.TryGetValue(axisName, out var listener) && listener.action.triggered;
        }

        public override bool GetButtonUp(string axisName)
        {
            return stateListeners.TryGetValue(axisName, out var listener) && listener.cancelled;
        }

        public override bool GetKey(KeyCode key)
        {
            return keyActions[(int) key]?.isPressed ?? false;
        }

        public override bool GetKey(string keyCodeName)
        {
            return GetKey(KeyNames.NameToKey(keyCodeName));
        }

        public override bool GetKeyUp(KeyCode key)
        {
            return keyActions[(int) key]?.cancelled ?? false;
        }

        public override bool GetKeyUp(string keyCodeName)
        {
            return GetKeyUp(KeyNames.NameToKey(keyCodeName));
        }

        public override bool GetKeyDown(KeyCode key)
        {
            return keyActions[(int) key]?.action.triggered ?? false;
        }

        public override bool GetKeyDown(string keyCodeName)
        {
            return GetKeyDown(KeyNames.NameToKey(keyCodeName));
        }

        public override bool IsAnyKeyPressed()
        {
            return anyKeyStateListener.isPressed;
        }

        public override bool IsAnyKeyDown()
        {
            return anyKeyStateListener.action.triggered;
        }

        public override string GetInputString()
        {
            return ""; // TODO
        }

        public override bool IsMousePresent()
        {
            return Mouse.current != null;
        }

        public override Vector3 GetMousePosition()
        {
            // seems like Z is always 0.0f
            return Mouse.current != null ? new Vector3(Mouse.current.position.x.ReadValue(), Mouse.current.position.y.ReadValue(), 0.0f) : Vector3.zero;
        }

        public override Vector2 GetMouseScrollDelta()
        {
            return Mouse.current != null ? new Vector2(Mouse.current.scroll.x.ReadValue(), Mouse.current.scroll.y.ReadValue()) : Vector2.zero;
        }

        public override bool GetMouseButton(int buttonNumber)
        {
            var keyCode = ControlPathMapper.GetMouseKeyCodeForButtonNumber(buttonNumber);
            if (keyCode.HasValue)
                return keyActions[(int) keyCode]?.isPressed ?? false;
            return false;
        }

        public override bool GetMouseButtonDown(int buttonNumber)
        {
            var keyCode = ControlPathMapper.GetMouseKeyCodeForButtonNumber(buttonNumber);
            if (keyCode.HasValue)
                return keyActions[(int) keyCode]?.action.triggered ?? false;
            return false;
        }

        public override bool GetMouseButtonUp(int buttonNumber)
        {
            var keyCode = ControlPathMapper.GetMouseKeyCodeForButtonNumber(buttonNumber);
            if (keyCode.HasValue)
                return keyActions[(int) keyCode]?.cancelled ?? false;
            return false;
        }
    };
}