using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Station : MonoBehaviour
{
    protected StationController currentController;

    protected virtual void OnTriggerEnter2D(Collider2D other)
    {
        if (currentController != null) return;
        currentController = other.gameObject.GetComponent<StationController>();
        currentController?.EnterStation(this);
    }
    
    public void Inject(PlayerInputController playerInputController)
    {
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

    }

    protected abstract void EjectAction();

    protected abstract void FireAction();

    protected abstract void HorizontalAction(float t);

    protected abstract void VerticalAction(float t);
}
