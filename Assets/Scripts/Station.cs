using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Station : MonoBehaviour
{

    public void Inject(PlayerInputController playerInputController)
    {
        playerInputController.ejectAction += EjectAction;
        playerInputController.fireAction += FireAction;
        playerInputController.horizontalAction += HorizontalAction;
        playerInputController.verticalAction += VerticalAction;

    }

    public void Eject(PlayerInputController playerInputController)
    {
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
