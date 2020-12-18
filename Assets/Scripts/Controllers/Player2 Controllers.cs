// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/Controllers/Player2 Controllers.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Player2Controllers : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @Player2Controllers()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Player2 Controllers"",
    ""maps"": [
        {
            ""name"": ""Player2"",
            ""id"": ""7e8451fc-9371-4239-9356-38cee7fb6cd8"",
            ""actions"": [
                {
                    ""name"": ""Horizontal Axis"",
                    ""type"": ""Value"",
                    ""id"": ""b8ceaa92-4795-45f5-910c-6f9c893a10ef"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Vertical Axis"",
                    ""type"": ""Value"",
                    ""id"": ""a6062c7b-8cc5-463f-9fe4-e90c715454b9"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Up_Fire"",
                    ""type"": ""Button"",
                    ""id"": ""bbe7d48b-869c-4861-b58e-df5a8fdcd7aa"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Eject"",
                    ""type"": ""Button"",
                    ""id"": ""9583258c-69f0-4088-b09f-7afb91b8acfa"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""21b3a005-661f-4cf7-a48e-7d8e77eed249"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Horizontal Axis"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""93e996c9-5a2a-4486-8ee2-6d6c484987aa"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Horizontal Axis"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""cb50387e-9ce1-4329-826d-cff33643906e"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Horizontal Axis"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""e017d708-ad8d-4440-9db8-b271cbe5e609"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Vertical Axis"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""81dbe678-7a8c-40e9-8e5c-a1af2b773fc1"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Vertical Axis"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""0ef7a307-e93a-44c7-9d33-fc1b0ce00a55"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Vertical Axis"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""bbcaf99b-6be5-4e3e-8c65-62919b9a452a"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Up_Fire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b905a373-4de2-4f53-a80d-130b613de1fc"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Eject"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Player2
        m_Player2 = asset.FindActionMap("Player2", throwIfNotFound: true);
        m_Player2_HorizontalAxis = m_Player2.FindAction("Horizontal Axis", throwIfNotFound: true);
        m_Player2_VerticalAxis = m_Player2.FindAction("Vertical Axis", throwIfNotFound: true);
        m_Player2_Up_Fire = m_Player2.FindAction("Up_Fire", throwIfNotFound: true);
        m_Player2_Eject = m_Player2.FindAction("Eject", throwIfNotFound: true);
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

    // Player2
    private readonly InputActionMap m_Player2;
    private IPlayer2Actions m_Player2ActionsCallbackInterface;
    private readonly InputAction m_Player2_HorizontalAxis;
    private readonly InputAction m_Player2_VerticalAxis;
    private readonly InputAction m_Player2_Up_Fire;
    private readonly InputAction m_Player2_Eject;
    public struct Player2Actions
    {
        private @Player2Controllers m_Wrapper;
        public Player2Actions(@Player2Controllers wrapper) { m_Wrapper = wrapper; }
        public InputAction @HorizontalAxis => m_Wrapper.m_Player2_HorizontalAxis;
        public InputAction @VerticalAxis => m_Wrapper.m_Player2_VerticalAxis;
        public InputAction @Up_Fire => m_Wrapper.m_Player2_Up_Fire;
        public InputAction @Eject => m_Wrapper.m_Player2_Eject;
        public InputActionMap Get() { return m_Wrapper.m_Player2; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(Player2Actions set) { return set.Get(); }
        public void SetCallbacks(IPlayer2Actions instance)
        {
            if (m_Wrapper.m_Player2ActionsCallbackInterface != null)
            {
                @HorizontalAxis.started -= m_Wrapper.m_Player2ActionsCallbackInterface.OnHorizontalAxis;
                @HorizontalAxis.performed -= m_Wrapper.m_Player2ActionsCallbackInterface.OnHorizontalAxis;
                @HorizontalAxis.canceled -= m_Wrapper.m_Player2ActionsCallbackInterface.OnHorizontalAxis;
                @VerticalAxis.started -= m_Wrapper.m_Player2ActionsCallbackInterface.OnVerticalAxis;
                @VerticalAxis.performed -= m_Wrapper.m_Player2ActionsCallbackInterface.OnVerticalAxis;
                @VerticalAxis.canceled -= m_Wrapper.m_Player2ActionsCallbackInterface.OnVerticalAxis;
                @Up_Fire.started -= m_Wrapper.m_Player2ActionsCallbackInterface.OnUp_Fire;
                @Up_Fire.performed -= m_Wrapper.m_Player2ActionsCallbackInterface.OnUp_Fire;
                @Up_Fire.canceled -= m_Wrapper.m_Player2ActionsCallbackInterface.OnUp_Fire;
                @Eject.started -= m_Wrapper.m_Player2ActionsCallbackInterface.OnEject;
                @Eject.performed -= m_Wrapper.m_Player2ActionsCallbackInterface.OnEject;
                @Eject.canceled -= m_Wrapper.m_Player2ActionsCallbackInterface.OnEject;
            }
            m_Wrapper.m_Player2ActionsCallbackInterface = instance;
            if (instance != null)
            {
                @HorizontalAxis.started += instance.OnHorizontalAxis;
                @HorizontalAxis.performed += instance.OnHorizontalAxis;
                @HorizontalAxis.canceled += instance.OnHorizontalAxis;
                @VerticalAxis.started += instance.OnVerticalAxis;
                @VerticalAxis.performed += instance.OnVerticalAxis;
                @VerticalAxis.canceled += instance.OnVerticalAxis;
                @Up_Fire.started += instance.OnUp_Fire;
                @Up_Fire.performed += instance.OnUp_Fire;
                @Up_Fire.canceled += instance.OnUp_Fire;
                @Eject.started += instance.OnEject;
                @Eject.performed += instance.OnEject;
                @Eject.canceled += instance.OnEject;
            }
        }
    }
    public Player2Actions @Player2 => new Player2Actions(this);
    public interface IPlayer2Actions
    {
        void OnHorizontalAxis(InputAction.CallbackContext context);
        void OnVerticalAxis(InputAction.CallbackContext context);
        void OnUp_Fire(InputAction.CallbackContext context);
        void OnEject(InputAction.CallbackContext context);
    }
}
