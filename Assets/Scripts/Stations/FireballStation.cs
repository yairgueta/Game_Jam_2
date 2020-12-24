using UnityEngine;

namespace Stations
{
    public class FireballStation : AimingStation
    {
        [Header("Fireball Attributes")]
        [SerializeField] private GameObject fireballPrefab;
        [SerializeField] private Transform spawnPoint;
        [SerializeField] private float fireForce = 100f;

        protected override void EjectAction()
        {
            currentController?.ExitStation();
        }

        protected override void FireAction()
        {
            //Fire
            Rigidbody2D fireballRb2d = Instantiate(fireballPrefab, spawnPoint.position, spawnPoint.rotation).GetComponent<Rigidbody2D>();
            fireballRb2d.AddForce(spawnPoint.up*fireForce, ForceMode2D.Impulse);
        
        }
        
        protected override void VerticalAction(float t) { }
    }
}
