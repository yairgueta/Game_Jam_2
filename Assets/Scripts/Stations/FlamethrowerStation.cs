using UnityEngine;
using UnityEngine.Events;

namespace Stations
{
    public class FlamethrowerStation : AimingStation
    {
        [Header("Flame Attributes")] 
        public UnityEvent onFlameStart;
        public UnityEvent onFlameEnd;

        private bool isFiring;
        
        protected override void EjectAction()
        {
            currentController?.ExitStation();
            if (isFiring) EndFlame();
        }

        protected override void FireAction() { }
        

        protected override void VerticalAction(float t)
        {
            const float treshold = .1f;
            if (t > treshold && !isFiring) StartFlame();
            else if (t <= treshold && isFiring) EndFlame();
        }

        private void StartFlame()
        {
            isFiring = true;
            onFlameStart?.Invoke();
        }

        private void EndFlame()
        {
            isFiring = false;
            onFlameEnd?.Invoke();
        }
    }
}
