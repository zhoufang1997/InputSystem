using System;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.InputSystem.OldInputCompatibility
{
    internal class ApiShimDataProvider : Input.DataProvider
    {
        public ApiShimDataProvider(InputActionMap setMap, IDictionary<string, ActionStateListener> setStateListeners, ActionStateListener[] setKeyActions)
        {
            map = setMap;
            stateListeners = setStateListeners;
            keyActions = setKeyActions;
        }

        private InputActionMap map;
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
    };
}