// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/PlayerActions.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerActions : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerActions"",
    ""maps"": [
        {
            ""name"": ""HydraMovement"",
            ""id"": ""12a15d34-6479-4fb3-92fa-758efbf4aa92"",
            ""actions"": [
                {
                    ""name"": ""Rotation"",
                    ""type"": ""Button"",
                    ""id"": ""5990fe14-3d7e-460b-96c9-e87b822d02a4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Forward"",
                    ""type"": ""Button"",
                    ""id"": ""5b846d52-0a95-406c-8899-24e4db50247f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Rotate"",
                    ""id"": ""040ca3a5-698f-48ee-83fa-c861a6ffa7b3"",
                    ""path"": ""1DAxis"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotation"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""3286c3ea-5315-4b5e-a340-7155087c815f"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""0e895d27-13b4-4b01-8e1b-69a9a2e3c8df"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""dbf1ec1c-fb98-464f-967c-9c545fa78757"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Forward"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
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
        },
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
        // HydraMovement
        m_HydraMovement = asset.FindActionMap("HydraMovement", throwIfNotFound: true);
        m_HydraMovement_Rotation = m_HydraMovement.FindAction("Rotation", throwIfNotFound: true);
        m_HydraMovement_Forward = m_HydraMovement.FindAction("Forward", throwIfNotFound: true);
        // Player1
        m_Player1 = asset.FindActionMap("Player1", throwIfNotFound: true);
        m_Player1_HorizontalAxis = m_Player1.FindAction("Horizontal Axis", throwIfNotFound: true);
        m_Player1_VerticalAxis = m_Player1.FindAction("Vertical Axis", throwIfNotFound: true);
        m_Player1_Up_Fire = m_Player1.FindAction("Up_Fire", throwIfNotFound: true);
        m_Player1_Eject = m_Player1.FindAction("Eject", throwIfNotFound: true);
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

    // HydraMovement
    private readonly InputActionMap m_HydraMovement;
    private IHydraMovementActions m_HydraMovementActionsCallbackInterface;
    private readonly InputAction m_HydraMovement_Rotation;
    private readonly InputAction m_HydraMovement_Forward;
    public struct HydraMovementActions
    {
        private @PlayerActions m_Wrapper;
        public HydraMovementActions(@PlayerActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Rotation => m_Wrapper.m_HydraMovement_Rotation;
        public InputAction @Forward => m_Wrapper.m_HydraMovement_Forward;
        public InputActionMap Get() { return m_Wrapper.m_HydraMovement; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(HydraMovementActions set) { return set.Get(); }
        public void SetCallbacks(IHydraMovementActions instance)
        {
            if (m_Wrapper.m_HydraMovementActionsCallbackInterface != null)
            {
                @Rotation.started -= m_Wrapper.m_HydraMovementActionsCallbackInterface.OnRotation;
                @Rotation.performed -= m_Wrapper.m_HydraMovementActionsCallbackInterface.OnRotation;
                @Rotation.canceled -= m_Wrapper.m_HydraMovementActionsCallbackInterface.OnRotation;
                @Forward.started -= m_Wrapper.m_HydraMovementActionsCallbackInterface.OnForward;
                @Forward.performed -= m_Wrapper.m_HydraMovementActionsCallbackInterface.OnForward;
                @Forward.canceled -= m_Wrapper.m_HydraMovementActionsCallbackInterface.OnForward;
            }
            m_Wrapper.m_HydraMovementActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Rotation.started += instance.OnRotation;
                @Rotation.performed += instance.OnRotation;
                @Rotation.canceled += instance.OnRotation;
                @Forward.started += instance.OnForward;
                @Forward.performed += instance.OnForward;
                @Forward.canceled += instance.OnForward;
            }
        }
    }
    public HydraMovementActions @HydraMovement => new HydraMovementActions(this);

    // Player1
    private readonly InputActionMap m_Player1;
    private IPlayer1Actions m_Player1ActionsCallbackInterface;
    private readonly InputAction m_Player1_HorizontalAxis;
    private readonly InputAction m_Player1_VerticalAxis;
    private readonly InputAction m_Player1_Up_Fire;
    private readonly InputAction m_Player1_Eject;
    public struct Player1Actions
    {
        private @PlayerActions m_Wrapper;
        public Player1Actions(@PlayerActions wrapper) { m_Wrapper = wrapper; }
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

    // Player2
    private readonly InputActionMap m_Player2;
    private IPlayer2Actions m_Player2ActionsCallbackInterface;
    private readonly InputAction m_Player2_HorizontalAxis;
    private readonly InputAction m_Player2_VerticalAxis;
    private readonly InputAction m_Player2_Up_Fire;
    private readonly InputAction m_Player2_Eject;
    public struct Player2Actions
    {
        private @PlayerActions m_Wrapper;
        public Player2Actions(@PlayerActions wrapper) { m_Wrapper = wrapper; }
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
    public interface IHydraMovementActions
    {
        void OnRotation(InputAction.CallbackContext context);
        void OnForward(InputAction.CallbackContext context);
    }
    public interface IPlayer1Actions
    {
        void OnHorizontalAxis(InputAction.CallbackContext context);
        void OnVerticalAxis(InputAction.CallbackContext context);
        void OnUp_Fire(InputAction.CallbackContext context);
        void OnEject(InputAction.CallbackContext context);
    }
    public interface IPlayer2Actions
    {
        void OnHorizontalAxis(InputAction.CallbackContext context);
        void OnVerticalAxis(InputAction.CallbackContext context);
        void OnUp_Fire(InputAction.CallbackContext context);
        void OnEject(InputAction.CallbackContext context);
    }
}
