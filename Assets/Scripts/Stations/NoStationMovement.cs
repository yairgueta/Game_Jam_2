using UnityEngine;
using UnityEngine.Rendering;

namespace Stations
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class NoStationMovement : Station
    {
        [Header("Player Movement Attributes")]
        public float speed;

        private SerializedDictionary<Collider2D, ContactPoint2D[]> contactPoints;
        private Vector2 movement;
    
        protected override void Start()
        {
            base.Start();
            stationType = StationTypeEnum.NoStation;
            OnEjection += () => movement = Vector2.zero;
            contactPoints = new SerializedDictionary<Collider2D, ContactPoint2D[]>();
        }
    
        private void FixedUpdate()
        {
            movement = movement.normalized;
            float outForces = 1;
            var dir = movement;
            int i = 0;
            foreach (var cpArr in contactPoints.Values)
            {
                i++;
                foreach (var cp in cpArr)
                {
                    if (cp.Equals(default(ContactPoint2D))) break;
                    Vector2 normal = cp.normal;
                    outForces = -Vector2.Dot(movement, normal); 
                    var reflection = Vector2.Reflect(movement, normal).normalized; 
                    movement += Mathf.Sign(outForces)*reflection;
                    movement.Normalize();
                }
            }
            Vector2 delta = speed * Time.fixedDeltaTime * movement.normalized;
            transform.Translate(delta, Space.World);
        }

        protected override void EjectAction() { }

        protected override void FireAction(){ }

        protected override void HorizontalAction(float t)
        {
            movement.x = t;
        }

        protected override void VerticalAction(float t)
        {
            movement.y = t;
        }

        private void OnCollisionEnter2D(Collision2D other)
        {
            int MAX_CP = 5;
            contactPoints[other.collider] = new ContactPoint2D[MAX_CP];
            int n = other.GetContacts(contactPoints[other.collider]);
            if (n < MAX_CP)
                contactPoints[other.collider][n] = default(ContactPoint2D);
        }

        private void OnCollisionStay2D(Collision2D other)
        {
            int MAX_CP = 5;
            contactPoints[other.collider] = new ContactPoint2D[MAX_CP];
            int n = other.GetContacts(contactPoints[other.collider]);
            if (n < MAX_CP)
                contactPoints[other.collider][n] = default(ContactPoint2D);
        }

        private void OnCollisionExit2D(Collision2D other)
        {
            contactPoints.Remove(other.collider);

        }
    }
}
