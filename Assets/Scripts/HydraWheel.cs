using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HydraWheel : Station
{
    protected override void EjectAction()
    {
        currentController?.ExitStation();
    }

    protected override void FireAction() { }

    protected override void HorizontalAction(float t)
    {
        HydraMovement.Rotate = t;
    }

    protected override void VerticalAction(float t)
    {
        HydraMovement.MoveForward = Mathf.Clamp01(t);
    }
}
