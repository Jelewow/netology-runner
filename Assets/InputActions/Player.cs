//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.4
//     from Assets/InputActions/Player.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

namespace Netology.Runner.Input
{
    public partial class @PlayerNewInput : IInputActionCollection2, IDisposable
    {
        public InputActionAsset asset { get; }
        public @PlayerNewInput()
        {
            asset = InputActionAsset.FromJson(@"{
    ""name"": ""Player"",
    ""maps"": [
        {
            ""name"": ""Move"",
            ""id"": ""8978c212-0445-4c28-b3df-1d5755d5dcea"",
            ""actions"": [
                {
                    ""name"": ""Moving"",
                    ""type"": ""Value"",
                    ""id"": ""ba6edf10-0733-4514-bb36-d346bda4c846"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Jumping"",
                    ""type"": ""Button"",
                    ""id"": ""6359f244-7f05-4e5b-afa4-62ebecc7c590"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""875bc642-b6f5-4e80-aff5-ffc93e05ceca"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Moving"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""70a3d0b8-ad11-4688-a7c7-28d65d818b40"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Desktop"",
                    ""action"": ""Moving"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""f0b30d8d-ad7e-4bea-b6a9-6e377cbe1000"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Desktop"",
                    ""action"": ""Moving"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""8b9d88a0-682c-41b9-9030-8a147717129d"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Desktop"",
                    ""action"": ""Jumping"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Desktop"",
            ""bindingGroup"": ""Desktop"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
            // Move
            m_Move = asset.FindActionMap("Move", throwIfNotFound: true);
            m_Move_Moving = m_Move.FindAction("Moving", throwIfNotFound: true);
            m_Move_Jumping = m_Move.FindAction("Jumping", throwIfNotFound: true);
        }

        public void Dispose()
        {
            UnityEngine.Object.Destroy(asset);
        }

        public InputBinding? bindingMask
        {
            get => asset.bindingMask;
            set => asset.bindingMask = value;
        }

        public ReadOnlyArray<InputDevice>? devices
        {
            get => asset.devices;
            set => asset.devices = value;
        }

        public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

        public bool Contains(InputAction action)
        {
            return asset.Contains(action);
        }

        public IEnumerator<InputAction> GetEnumerator()
        {
            return asset.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Enable()
        {
            asset.Enable();
        }

        public void Disable()
        {
            asset.Disable();
        }
        public IEnumerable<InputBinding> bindings => asset.bindings;

        public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
        {
            return asset.FindAction(actionNameOrId, throwIfNotFound);
        }
        public int FindBinding(InputBinding bindingMask, out InputAction action)
        {
            return asset.FindBinding(bindingMask, out action);
        }

        // Move
        private readonly InputActionMap m_Move;
        private IMoveActions m_MoveActionsCallbackInterface;
        private readonly InputAction m_Move_Moving;
        private readonly InputAction m_Move_Jumping;
        public struct MoveActions
        {
            private @PlayerNewInput m_Wrapper;
            public MoveActions(@PlayerNewInput wrapper) { m_Wrapper = wrapper; }
            public InputAction @Moving => m_Wrapper.m_Move_Moving;
            public InputAction @Jumping => m_Wrapper.m_Move_Jumping;
            public InputActionMap Get() { return m_Wrapper.m_Move; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(MoveActions set) { return set.Get(); }
            public void SetCallbacks(IMoveActions instance)
            {
                if (m_Wrapper.m_MoveActionsCallbackInterface != null)
                {
                    @Moving.started -= m_Wrapper.m_MoveActionsCallbackInterface.OnMoving;
                    @Moving.performed -= m_Wrapper.m_MoveActionsCallbackInterface.OnMoving;
                    @Moving.canceled -= m_Wrapper.m_MoveActionsCallbackInterface.OnMoving;
                    @Jumping.started -= m_Wrapper.m_MoveActionsCallbackInterface.OnJumping;
                    @Jumping.performed -= m_Wrapper.m_MoveActionsCallbackInterface.OnJumping;
                    @Jumping.canceled -= m_Wrapper.m_MoveActionsCallbackInterface.OnJumping;
                }
                m_Wrapper.m_MoveActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @Moving.started += instance.OnMoving;
                    @Moving.performed += instance.OnMoving;
                    @Moving.canceled += instance.OnMoving;
                    @Jumping.started += instance.OnJumping;
                    @Jumping.performed += instance.OnJumping;
                    @Jumping.canceled += instance.OnJumping;
                }
            }
        }
        public MoveActions @Move => new MoveActions(this);
        private int m_DesktopSchemeIndex = -1;
        public InputControlScheme DesktopScheme
        {
            get
            {
                if (m_DesktopSchemeIndex == -1) m_DesktopSchemeIndex = asset.FindControlSchemeIndex("Desktop");
                return asset.controlSchemes[m_DesktopSchemeIndex];
            }
        }
        public interface IMoveActions
        {
            void OnMoving(InputAction.CallbackContext context);
            void OnJumping(InputAction.CallbackContext context);
        }
    }
}