using Hydra;
using UnityEngine;

namespace Stations
{
    public class HydraWheel : Station
    {
        protected override void Start()
        {
            base.Start();
            stationType = StationTypeEnum.Wheel;
        }

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
}
