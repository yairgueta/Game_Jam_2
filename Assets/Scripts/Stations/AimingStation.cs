using UnityEngine;

namespace Stations
{
    public abstract class AimingStation : Station
    {
        
        [Header("Aiming Attributes")]
        [SerializeField] private GameObject hydraHead;
        [SerializeField] protected float maxAimAngle = 25f;
        [SerializeField] protected float aimSpeed = 100f;

        protected float aimAngle;

        protected override void Start()
        {
            base.Start();
            stationType = StationTypeEnum.Aiming;
            aimAngle = 0;
        }

        private void Update()
        {
            hydraHead.transform.localRotation = Quaternion.Euler(0, 0, aimAngle);
        }
        
        protected override void HorizontalAction(float t)
        {
            aimAngle = Mathf.Clamp(aimAngle - t * Time.deltaTime* aimSpeed, - maxAimAngle, maxAimAngle);
        }
        
        private void OnDrawGizmosSelected()
        {
            Gizmos.color = Color.red;
            var pos = hydraHead.transform.position;
        
            transform.rotation.ToAngleAxis(out var angle, out var axis);
            angle = 90 + angle * axis.z + maxAimAngle;
            Vector3 dir = new Vector2(Mathf.Cos(Mathf.Deg2Rad * angle), Mathf.Sin(Mathf.Deg2Rad * angle)).normalized;
        
            Gizmos.DrawLine(pos, pos + 3 * dir);
            Gizmos.DrawLine(pos, pos + Vector3.Reflect(3 * dir, transform.right));
        }
        
    }
}
