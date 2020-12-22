using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Station : MonoBehaviour
{
    [Header("General Station Attributes")] 
    [SerializeField] protected TriggerActionInvoker triggerActionInvoker;
    
    private bool isActive = true;
    protected StationController currentController;
    protected Action OnEjection;

    protected virtual void Start()
    {
        if (triggerActionInvoker == null) return;
        triggerActionInvoker.OnTriggerAction += other =>
        {
            if (currentController != null) return;
            currentController = other.gameObject.GetComponent<StationController>();
            currentController?.EnterStation(this);
        };
    }

    public void Inject(PlayerInputController playerInputController)
    {
        if (!isActive) return;
        playerInputController.ejectAction += EjectAction;
        playerInputController.fireAction += FireAction;
        playerInputController.horizontalAction += HorizontalAction;
        playerInputController.verticalAction += VerticalAction;
        
    }

    public void Eject(PlayerInputController playerInputController)
    {
        currentController = null;
        playerInputController.ejectAction -= EjectAction;
        playerInputController.fireAction -= FireAction;
        playerInputController.horizontalAction -= HorizontalAction;
        playerInputController.verticalAction -= VerticalAction;

        OnEjection?.Invoke();
    }

    public virtual void DisableStation()
    {
        if (currentController != null)
        {
            currentController.ExitStation();
        }

        isActive = false;
    }   
    
    protected abstract void EjectAction();

    protected abstract void FireAction();

    protected abstract void HorizontalAction(float t);

    protected abstract void VerticalAction(float t);
}
