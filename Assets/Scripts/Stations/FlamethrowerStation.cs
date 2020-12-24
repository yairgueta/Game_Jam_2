using UnityEngine;

namespace Stations
{
    public class FlamethrowerStation : AimingStation
    {
        [Header("Flame Attributes")]
        [SerializeField] private GameObject flamethrowerObject;
        
        
        protected override void EjectAction()
        {
            flamethrowerObject.SetActive(false);
            currentController?.ExitStation();
        }

        protected override void FireAction() { }
        

        protected override void VerticalAction(float t)
        {
            flamethrowerObject.SetActive(t > .1f);
        }
    }
}
