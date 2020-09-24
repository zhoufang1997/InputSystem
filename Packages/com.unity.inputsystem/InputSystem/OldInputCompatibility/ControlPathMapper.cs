using UnityEngine;

namespace UnityEngine.InputSystem.OldInputCompatibility
{
    internal class ControlPathMapper
    {
        public static string GetKeyboardControlActionNameForKeyCode(string keyCodeName)
        {
            return $"KeyboardKey{keyCodeName}";
        }

        public static string GetKeyboardControlActionNameForKeyCode(KeyCode keyCode)
        {
            return GetKeyboardControlActionNameForKeyCode(keyCode.ToString());
        }

        public static string GetKeyboardControlPathForKeyCode(KeyCode keyCode, string usage)
        {
            switch (keyCode)
            {
                // Bind by display name rather than key code. Means we respect keyboard layouts
                // like the old input system does.
                case KeyCode.Escape: return $"<Keyboard>{usage}/#(Escape)";
                case KeyCode.Space: return $"<Keyboard>{usage}/#(Space)";
                //case KeyCode.Enter: return $"<Keyboard>{usage}/#(Enter)";
                case KeyCode.Tab: return $"<Keyboard>{usage}/#(Tab)";
                //case KeyCode.Backquote: return $"<Keyboard>{usage}/#(`)";
                case KeyCode.Quote: return $"<Keyboard>{usage}/#(')";
                case KeyCode.Semicolon: return $"<Keyboard>{usage}/#(;)";
                case KeyCode.Comma: return $"<Keyboard>{usage}/#(,)";
                case KeyCode.Period: return $"<Keyboard>{usage}/#(.)";
                case KeyCode.Slash: return $"<Keyboard>{usage}/#(/)";
                case KeyCode.Backslash: return $"<Keyboard>{usage}/#(\\)";
                case KeyCode.LeftBracket: return $"<Keyboard>{usage}/#([)";
                case KeyCode.RightBracket: return $"<Keyboard>{usage}/#(])";
                case KeyCode.Minus: return $"<Keyboard>{usage}/#(-)";
                case KeyCode.Equals: return $"<Keyboard>{usage}/#(=)";
                case KeyCode.UpArrow: return $"<Keyboard>{usage}/#(Up Arrow)";
                case KeyCode.DownArrow: return $"<Keyboard>{usage}/#(Down Arrow)";
                case KeyCode.LeftArrow: return $"<Keyboard>{usage}/#(Left Arrow)";
                case KeyCode.RightArrow: return $"<Keyboard>{usage}/#(Right Arrow)";
                case KeyCode.A: return $"<Keyboard>{usage}/#(A)";
                case KeyCode.B: return $"<Keyboard>{usage}/#(B)";
                case KeyCode.C: return $"<Keyboard>{usage}/#(C)";
                case KeyCode.D: return $"<Keyboard>{usage}/#(D)";
                case KeyCode.E: return $"<Keyboard>{usage}/#(E)";
                case KeyCode.F: return $"<Keyboard>{usage}/#(F)";
                case KeyCode.G: return $"<Keyboard>{usage}/#(G)";
                case KeyCode.H: return $"<Keyboard>{usage}/#(H)";
                case KeyCode.I: return $"<Keyboard>{usage}/#(I)";
                case KeyCode.J: return $"<Keyboard>{usage}/#(J)";
                case KeyCode.K: return $"<Keyboard>{usage}/#(K)";
                case KeyCode.L: return $"<Keyboard>{usage}/#(L)";
                case KeyCode.M: return $"<Keyboard>{usage}/#(M)";
                case KeyCode.N: return $"<Keyboard>{usage}/#(N)";
                case KeyCode.O: return $"<Keyboard>{usage}/#(O)";
                case KeyCode.P: return $"<Keyboard>{usage}/#(P)";
                case KeyCode.Q: return $"<Keyboard>{usage}/#(Q)";
                case KeyCode.R: return $"<Keyboard>{usage}/#(R)";
                case KeyCode.S: return $"<Keyboard>{usage}/#(S)";
                case KeyCode.T: return $"<Keyboard>{usage}/#(T)";
                case KeyCode.U: return $"<Keyboard>{usage}/#(U)";
                case KeyCode.V: return $"<Keyboard>{usage}/#(V)";
                case KeyCode.W: return $"<Keyboard>{usage}/#(W)";
                case KeyCode.X: return $"<Keyboard>{usage}/#(X)";
                case KeyCode.Y: return $"<Keyboard>{usage}/#(Y)";
                case KeyCode.Z: return $"<Keyboard>{usage}/#(Z)";
                // case KeyCode.Digit1: return $"<Keyboard>{usage}/#(1)";
                // case KeyCode.Digit2: return $"<Keyboard>{usage}/#(2)";
                // case KeyCode.Digit3: return $"<Keyboard>{usage}/#(3)";
                // case KeyCode.Digit4: return $"<Keyboard>{usage}/#(4)";
                // case KeyCode.Digit5: return $"<Keyboard>{usage}/#(5)";
                // case KeyCode.Digit6: return $"<Keyboard>{usage}/#(6)";
                // case KeyCode.Digit7: return $"<Keyboard>{usage}/#(7)";
                // case KeyCode.Digit8: return $"<Keyboard>{usage}/#(8)";
                // case KeyCode.Digit9: return $"<Keyboard>{usage}/#(9)";
                // case KeyCode.Digit0: return $"<Keyboard>{usage}/#(0)";
                case KeyCode.LeftShift: return $"<Keyboard>{usage}/#(Left Shift)";
                case KeyCode.RightShift: return $"<Keyboard>{usage}/#(Right Shift)";
                //case KeyCode.LeftShift: return $"<Keyboard>{usage}/#(Shift)";
                case KeyCode.LeftAlt: return $"<Keyboard>{usage}/#(Left Alt)";
                case KeyCode.RightAlt: return $"<Keyboard>{usage}/#(Right Alt)";
                //case KeyCode.LeftAlt: return $"<Keyboard>{usage}/#(Alt)";
                // case KeyCode.LeftCtrl: return $"<Keyboard>{usage}/#(Left Control)";
                // case KeyCode.RightCtrl: return $"<Keyboard>{usage}/#(Right Control)";
                // case KeyCode.LeftCtrl: return $"<Keyboard>{usage}/#(Control)";
                // case KeyCode.LeftMeta: return $"<Keyboard>{usage}/#(Left System)";
                // case KeyCode.RightMeta: return $"<Keyboard>{usage}/#(Right System)";
                // case KeyCode.ContextMenu: return $"<Keyboard>{usage}/#(Context Menu)";
                case KeyCode.Backspace: return $"<Keyboard>{usage}/#(Backspace)";
                case KeyCode.PageDown: return $"<Keyboard>{usage}/#(Page Down)";
                case KeyCode.PageUp: return $"<Keyboard>{usage}/#(Page Up)";
                case KeyCode.Home: return $"<Keyboard>{usage}/#(Home)";
                case KeyCode.End: return $"<Keyboard>{usage}/#(End)";
                case KeyCode.Insert: return $"<Keyboard>{usage}/#(Insert)";
                case KeyCode.Delete: return $"<Keyboard>{usage}/#(Delete)";
                case KeyCode.CapsLock: return $"<Keyboard>{usage}/#(Caps Lock)";
                // case KeyCode.NumLock: return $"<Keyboard>{usage}/#(Num Lock)";
                // case KeyCode.PrintScreen: return $"<Keyboard>{usage}/#(Print Screen)";
                case KeyCode.ScrollLock: return $"<Keyboard>{usage}/#(Scroll Lock)";
                case KeyCode.Pause: return $"<Keyboard>{usage}/#(Pause/Break)";
                // case KeyCode.NumpadEnter: return $"<Keyboard>{usage}/#(Numpad Enter)";
                // case KeyCode.NumpadDivide: return $"<Keyboard>{usage}/#(Numpad /)";
                // case KeyCode.NumpadMultiply: return $"<Keyboard>{usage}/#(Numpad *)";
                // case KeyCode.NumpadPlus: return $"<Keyboard>{usage}/#(Numpad +)";
                // case KeyCode.NumpadMinus: return $"<Keyboard>{usage}/#(Numpad -)";
                // case KeyCode.NumpadPeriod: return $"<Keyboard>{usage}/#(Numpad .)";
                // case KeyCode.NumpadEquals: return $"<Keyboard>{usage}/#(Numpad =)";
                // case KeyCode.Numpad1: return $"<Keyboard>{usage}/#(Numpad 1)";
                // case KeyCode.Numpad2: return $"<Keyboard>{usage}/#(Numpad 2)";
                // case KeyCode.Numpad3: return $"<Keyboard>{usage}/#(Numpad 3)";
                // case KeyCode.Numpad4: return $"<Keyboard>{usage}/#(Numpad 4)";
                // case KeyCode.Numpad5: return $"<Keyboard>{usage}/#(Numpad 5)";
                // case KeyCode.Numpad6: return $"<Keyboard>{usage}/#(Numpad 6)";
                // case KeyCode.Numpad7: return $"<Keyboard>{usage}/#(Numpad 7)";
                // case KeyCode.Numpad8: return $"<Keyboard>{usage}/#(Numpad 8)";
                // case KeyCode.Numpad9: return $"<Keyboard>{usage}/#(Numpad 9)";
                // case KeyCode.Numpad0: return $"<Keyboard>{usage}/#(Numpad 0)";
                case KeyCode.F1: return $"<Keyboard>{usage}/#(F1)";
                case KeyCode.F2: return $"<Keyboard>{usage}/#(F2)";
                case KeyCode.F3: return $"<Keyboard>{usage}/#(F3)";
                case KeyCode.F4: return $"<Keyboard>{usage}/#(F4)";
                case KeyCode.F5: return $"<Keyboard>{usage}/#(F5)";
                case KeyCode.F6: return $"<Keyboard>{usage}/#(F6)";
                case KeyCode.F7: return $"<Keyboard>{usage}/#(F7)";
                case KeyCode.F8: return $"<Keyboard>{usage}/#(F8)";
                case KeyCode.F9: return $"<Keyboard>{usage}/#(F9)";
                case KeyCode.F10: return $"<Keyboard>{usage}/#(F10)";
                case KeyCode.F11: return $"<Keyboard>{usage}/#(F11)";
                case KeyCode.F12: return $"<Keyboard>{usage}/#(F12)";
                // case KeyCode.OEM1: return $"<Keyboard>{usage}/#(OEM1)";
                // case KeyCode.OEM2: return $"<Keyboard>{usage}/#(OEM2)";
                // case KeyCode.OEM3: return $"<Keyboard>{usage}/#(OEM3)";
                // case KeyCode.OEM4: return $"<Keyboard>{usage}/#(OEM4)";
                // case KeyCode.OEM5: return $"<Keyboard>{usage}/#(OEM5)";
                // case KeyCode.IMESelected: return $"<Keyboard>{usage}/#(IMESelected)";

                //etc.

/*

    Backspace = 8,
    Tab = 9,
    Clear = 12, // 0x0000000C
    Return = 13, // 0x0000000D
    Pause = 19, // 0x00000013
    Escape = 27, // 0x0000001B
    Space = 32, // 0x00000020
    Exclaim = 33, // 0x00000021
    DoubleQuote = 34, // 0x00000022
    Hash = 35, // 0x00000023
    Dollar = 36, // 0x00000024
    Percent = 37, // 0x00000025
    Ampersand = 38, // 0x00000026
    Quote = 39, // 0x00000027
    LeftParen = 40, // 0x00000028
    RightParen = 41, // 0x00000029
    Asterisk = 42, // 0x0000002A
    Plus = 43, // 0x0000002B
    Comma = 44, // 0x0000002C
    Minus = 45, // 0x0000002D
    Period = 46, // 0x0000002E
    Slash = 47, // 0x0000002F
    Alpha0 = 48, // 0x00000030
    Alpha1 = 49, // 0x00000031
    Alpha2 = 50, // 0x00000032
    Alpha3 = 51, // 0x00000033
    Alpha4 = 52, // 0x00000034
    Alpha5 = 53, // 0x00000035
    Alpha6 = 54, // 0x00000036
    Alpha7 = 55, // 0x00000037
    Alpha8 = 56, // 0x00000038
    Alpha9 = 57, // 0x00000039
    Colon = 58, // 0x0000003A
    Semicolon = 59, // 0x0000003B
    Less = 60, // 0x0000003C
    Equals = 61, // 0x0000003D
    Greater = 62, // 0x0000003E
    Question = 63, // 0x0000003F
    At = 64, // 0x00000040
    LeftBracket = 91, // 0x0000005B
    Backslash = 92, // 0x0000005C
    RightBracket = 93, // 0x0000005D
    Caret = 94, // 0x0000005E
    Underscore = 95, // 0x0000005F
    BackQuote = 96, // 0x00000060
    A = 97, // 0x00000061
    B = 98, // 0x00000062
    C = 99, // 0x00000063
    D = 100, // 0x00000064
    E = 101, // 0x00000065
    F = 102, // 0x00000066
    G = 103, // 0x00000067
    H = 104, // 0x00000068
    I = 105, // 0x00000069
    J = 106, // 0x0000006A
    K = 107, // 0x0000006B
    L = 108, // 0x0000006C
    M = 109, // 0x0000006D
    N = 110, // 0x0000006E
    O = 111, // 0x0000006F
    P = 112, // 0x00000070
    Q = 113, // 0x00000071
    R = 114, // 0x00000072
    S = 115, // 0x00000073
    T = 116, // 0x00000074
    U = 117, // 0x00000075
    V = 118, // 0x00000076
    W = 119, // 0x00000077
    X = 120, // 0x00000078
    Y = 121, // 0x00000079
    Z = 122, // 0x0000007A
    LeftCurlyBracket = 123, // 0x0000007B
    Pipe = 124, // 0x0000007C
    RightCurlyBracket = 125, // 0x0000007D
    Tilde = 126, // 0x0000007E
    Delete = 127, // 0x0000007F
    Keypad0 = 256, // 0x00000100
    Keypad1 = 257, // 0x00000101
    Keypad2 = 258, // 0x00000102
    Keypad3 = 259, // 0x00000103
    Keypad4 = 260, // 0x00000104
    Keypad5 = 261, // 0x00000105
    Keypad6 = 262, // 0x00000106
    Keypad7 = 263, // 0x00000107
    Keypad8 = 264, // 0x00000108
    Keypad9 = 265, // 0x00000109
    KeypadPeriod = 266, // 0x0000010A
    KeypadDivide = 267, // 0x0000010B
    KeypadMultiply = 268, // 0x0000010C
    KeypadMinus = 269, // 0x0000010D
    KeypadPlus = 270, // 0x0000010E
    KeypadEnter = 271, // 0x0000010F
    KeypadEquals = 272, // 0x00000110
    UpArrow = 273, // 0x00000111
    DownArrow = 274, // 0x00000112
    RightArrow = 275, // 0x00000113
    LeftArrow = 276, // 0x00000114
    Insert = 277, // 0x00000115
    Home = 278, // 0x00000116
    End = 279, // 0x00000117
    PageUp = 280, // 0x00000118
    PageDown = 281, // 0x00000119
    F1 = 282, // 0x0000011A
    F2 = 283, // 0x0000011B
    F3 = 284, // 0x0000011C
    F4 = 285, // 0x0000011D
    F5 = 286, // 0x0000011E
    F6 = 287, // 0x0000011F
    F7 = 288, // 0x00000120
    F8 = 289, // 0x00000121
    F9 = 290, // 0x00000122
    F10 = 291, // 0x00000123
    F11 = 292, // 0x00000124
    F12 = 293, // 0x00000125
    F13 = 294, // 0x00000126
    F14 = 295, // 0x00000127
    F15 = 296, // 0x00000128
    Numlock = 300, // 0x0000012C
    CapsLock = 301, // 0x0000012D
    ScrollLock = 302, // 0x0000012E
    RightShift = 303, // 0x0000012F
    LeftShift = 304, // 0x00000130
    RightControl = 305, // 0x00000131
    LeftControl = 306, // 0x00000132
    RightAlt = 307, // 0x00000133
    LeftAlt = 308, // 0x00000134
    RightApple = 309, // 0x00000135
    RightCommand = 309, // 0x00000135
    LeftApple = 310, // 0x00000136
    LeftCommand = 310, // 0x00000136
    LeftWindows = 311, // 0x00000137
    RightWindows = 312, // 0x00000138
    AltGr = 313, // 0x00000139
    Help = 315, // 0x0000013B
    Print = 316, // 0x0000013C
    SysReq = 317, // 0x0000013D
    Break = 318, // 0x0000013E
    Menu = 319, // 0x0000013F
    Mouse0 = 323, // 0x00000143
    Mouse1 = 324, // 0x00000144
    Mouse2 = 325, // 0x00000145
    Mouse3 = 326, // 0x00000146
    Mouse4 = 327, // 0x00000147
    Mouse5 = 328, // 0x00000148
    Mouse6 = 329, // 0x00000149
                    */
            }

            return null;
        }

        public static string GetMouseControlPathForKeyCode(KeyCode keyCode, string usage)
        {
            switch (keyCode)
            {
                case KeyCode.Mouse0: return $"<Mouse>{usage}/leftButton";
                case KeyCode.Mouse1: return $"<Mouse>{usage}/rightButton";
                case KeyCode.Mouse2: return $"<Mouse>{usage}/middleButton";
                ////REVIEW: With these two, is it this way around or the other?
                case KeyCode.Mouse3: return $"<Mouse>{usage}/forwardButton";
                case KeyCode.Mouse4: return $"<Mouse>{usage}/backButton";
            }

            return null;
        }

        public static string GetJoystickControlPathForKeyCode(KeyCode button, string usage)
        {
            switch (button)
            {
                case KeyCode.JoystickButton0: return $"<Joystick>{usage}/trigger";
                case KeyCode.JoystickButton1: return $"<Joystick>{usage}/button2";
                case KeyCode.JoystickButton2: return $"<Joystick>{usage}/button3";
                //etc.
            }

            return null;
        }

        public static string GetGamepadControlPathForKeyCode(KeyCode button, string usage)
        {
            ////REVIEW: If we do it platform-dependent like this and move things into the importer, we'll
            ////        have to make the imported asset dependent on the build target.

#if UNITY_STANDALONE_WIN || UNITY_EDITOR_WIN
            // Follow Xbox layout for gamepads.
            switch (button)
            {
                // https://answers.unity.com/questions/1350081/xbox-one-controller-mapping-solved.html
                case KeyCode.JoystickButton0: return $"<Gamepad>{usage}/buttonSouth";
                case KeyCode.JoystickButton1: return $"<Gamepad>{usage}/buttonEast";
                case KeyCode.JoystickButton2: return $"<Gamepad>{usage}/buttonWest";
                //etc.
            }
#endif

            ////TODO: other platforms
            ////TODO: fallback (maybe just use Windows path?)

            return null;
        }

        private const int kMaxJoysticks = 16;
        private const int kMaxButtonsPerJoystick = 19;

        public static KeyCode MapJoystickButtonToJoystick0(KeyCode code)
        {
            for (var i = 0; i < kMaxJoysticks; ++i)
            {
                var min = KeyCode.Joystick1Button0 + i * kMaxButtonsPerJoystick;
                var max = min + kMaxButtonsPerJoystick;
                if (code >= min && code <= max)
                    return KeyCode.Joystick1Button0 + ((int) code - (int) min);
            }

            return code;
        }

        public static int GetJoystickNumber(KeyCode keyCode)
        {
            for (var i = 0; i < kMaxJoysticks; ++i)
            {
                var min = KeyCode.Joystick1Button0 + i * kMaxButtonsPerJoystick;
                var max = min + kMaxButtonsPerJoystick;
                if (keyCode >= min && keyCode <= max)
                    return i;
            }

            return -1;
        }


        // For joystick buttons and axes, we have the situation that we don't just want to blindly
        // map to joystick and gamepad buttons of the input system. Instead, for the controllers that
        // the input system explicitly supports, we want to retain the mapping that buttons and axes
        // have (on the specific platform) in the old system. This means we can end up with several
        // bindings for each such joystick button/axis in the old system.


        // public static IEnumerable<string> GetControlPathsForJoystickAxis(string button)
        // {
        //     throw new NotImplementedException();
        // }
    }
}