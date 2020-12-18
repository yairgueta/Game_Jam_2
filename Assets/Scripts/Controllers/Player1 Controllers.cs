// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/Controllers/Player1 Controllers.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Player1Controllers : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @Player1Controllers()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Player1 Controllers"",
    ""maps"": [
        {
            ""name"": ""Player1"",
            ""id"": ""d0f88c0c-00b7-4aa1-891b-9e082cad365e"",
            ""actions"": [
                {
                    ""name"": ""Horizontal Axis"",
                    ""type"": ""Value"",
                    ""id"": ""7c9b9c30-b282-4d9e-9a94-487219b3253d"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Vertical Axis"",
                    ""type"": ""Value"",
                    ""id"": ""97f6c082-0a33-48c6-8830-87054d6ac2b1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Up_Fire"",
                    ""type"": ""Button"",
                    ""id"": ""5ecc6677-0b52-4472-a2d5-113d04a3d2e6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Eject"",
                    ""type"": ""Button"",
                    ""id"": ""6a601169-f622-4fc0-bc97-e324a71bd94f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""475de351-1c45-4893-9d39-4543d04ddbb6"",
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
                    ""id"": ""601dbef4-de45-4ab8-bc17-0d03ec851c9c"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Horizontal Axis"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""0aeb25c8-0ecb-42b1-86cc-91731b185c24"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Horizontal Axis"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""72494228-6f1b-461b-ba28-725dd1db8e7a"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Up_Fire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""890e306c-2d1b-4c35-a1ab-de6136851f3e"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Eject"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""d1ca971f-0371-4e9f-a02c-aca175e9e1c1"",
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
                    ""id"": ""030f752b-1eca-4b13-a777-074c382984ca"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Vertical Axis"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""8a994636-3a54-4c96-9ca6-e3e31e6e4cac"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Vertical Axis"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Player1
        m_Player1 = asset.FindActionMap("Player1", throwIfNotFound: true);
        m_Player1_HorizontalAxis = m_Player1.FindAction("Horizontal Axis", throwIfNotFound: true);
        m_Player1_VerticalAxis = m_Player1.FindAction("Vertical Axis", throwIfNotFound: true);
        m_Player1_Up_Fire = m_Player1.FindAction("Up_Fire", throwIfNotFound: true);
        m_Player1_Eject = m_Player1.FindAction("Eject", throwIfNotFound: true);
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

    // Player1
    private readonly InputActionMap m_Player1;
    private IPlayer1Actions m_Player1ActionsCallbackInterface;
    private readonly InputAction m_Player1_HorizontalAxis;
    private readonly InputAction m_Player1_VerticalAxis;
    private readonly InputAction m_Player1_Up_Fire;
    private readonly InputAction m_Player1_Eject;
    public struct Player1Actions
    {
        private @Player1Controllers m_Wrapper;
        public Player1Actions(@Player1Controllers wrapper) { m_Wrapper = wrapper; }
        public InputAction @HorizontalAxis => m_Wrapper.m_Player1_HorizontalAxis;
        public InputAction @VerticalAxis => m_Wrapper.m_Player1_VerticalAxis;
        public InputAction @Up_Fire => m_Wrapper.m_Player1_Up_Fire;
        public InputAction @Eject => m_Wrapper.m_Player1_Eject;
        public InputActionMap Get() { return m_Wrapper.m_Player1; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(Player1Actions set) { return set.Get(); }
        public void SetCallbacks(IPlayer1Actions instance)
        {
            if (m_Wrapper.m_Player1ActionsCallbackInterface != null)
            {
                @HorizontalAxis.started -= m_Wrapper.m_Player1ActionsCallbackInterface.OnHorizontalAxis;
                @HorizontalAxis.performed -= m_Wrapper.m_Player1ActionsCallbackInterface.OnHorizontalAxis;
                @HorizontalAxis.canceled -= m_Wrapper.m_Player1ActionsCallbackInterface.OnHorizontalAxis;
                @VerticalAxis.started -= m_Wrapper.m_Player1ActionsCallbackInterface.OnVerticalAxis;
                @VerticalAxis.performed -= m_Wrapper.m_Player1ActionsCallbackInterface.OnVerticalAxis;
                @VerticalAxis.canceled -= m_Wrapper.m_Player1ActionsCallbackInterface.OnVerticalAxis;
                @Up_Fire.started -= m_Wrapper.m_Player1ActionsCallbackInterface.OnUp_Fire;
                @Up_Fire.performed -= m_Wrapper.m_Player1ActionsCallbackInterface.OnUp_Fire;
                @Up_Fire.canceled -= m_Wrapper.m_Player1ActionsCallbackInterface.OnUp_Fire;
                @Eject.started -= m_Wrapper.m_Player1ActionsCallbackInterface.OnEject;
                @Eject.performed -= m_Wrapper.m_Player1ActionsCallbackInterface.OnEject;
                @Eject.canceled -= m_Wrapper.m_Player1ActionsCallbackInterface.OnEject;
            }
            m_Wrapper.m_Player1ActionsCallbackInterface = instance;
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
    public Player1Actions @Player1 => new Player1Actions(this);
    public interface IPlayer1Actions
    {
        void OnHorizontalAxis(InputAction.CallbackContext context);
        void OnVerticalAxis(InputAction.CallbackContext context);
        void OnUp_Fire(InputAction.CallbackContext context);
        void OnEject(InputAction.CallbackContext context);
    }
}
