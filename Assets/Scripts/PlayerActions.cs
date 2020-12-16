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
        }
    ],
    ""controlSchemes"": []
}");
        // HydraMovement
        m_HydraMovement = asset.FindActionMap("HydraMovement", throwIfNotFound: true);
        m_HydraMovement_Rotation = m_HydraMovement.FindAction("Rotation", throwIfNotFound: true);
        m_HydraMovement_Forward = m_HydraMovement.FindAction("Forward", throwIfNotFound: true);
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
    public interface IHydraMovementActions
    {
        void OnRotation(InputAction.CallbackContext context);
        void OnForward(InputAction.CallbackContext context);
    }
}
