using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class PlayerInputController : MonoBehaviour
{
    [HideInInspector] public Action<float> horizontalAction;
    [HideInInspector] public Action<float> verticalAction;
    [HideInInspector] public Action ejectAction;
    [HideInInspector] public Action fireAction;

    private PlayerInput playerInput;
    private InputAction horizontalActionInput;
    private InputAction verticalActionInput;
    


    private void Awake()
    {
        playerInput = GetComponent<PlayerInput>();
        horizontalActionInput = playerInput.actions["Horizontal Axis"];
        verticalActionInput = playerInput.actions["Vertical Axis"];
        playerInput.actions["Up_Fire"].performed += ctx => fireAction?.Invoke();
        playerInput.actions["Eject"].performed += ctx => ejectAction?.Invoke();
    }
    
    private void Update()
    {
        horizontalAction?.Invoke(horizontalActionInput.ReadValue<float>());
        verticalAction?.Invoke(verticalActionInput.ReadValue<float>());
    }

}
