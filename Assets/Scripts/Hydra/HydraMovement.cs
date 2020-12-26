using UnityEngine;
using UnityEngine.Events;

namespace Hydra
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class HydraMovement : MonoBehaviour
    {
        public UnityEvent<Vector2> onHydraMove;
        [SerializeField] private float speed = 7f;
        [SerializeField] private float rotationSpeed = 150f;
    
        private Rigidbody2D wholeRb2d;
        private static float rotate;
        private static float moveForward;

        private void Start()
        {
            wholeRb2d = GetComponent<Rigidbody2D>();
            wholeRb2d.centerOfMass = Vector2.zero;
        }
    
        private void FixedUpdate()
        {
            wholeRb2d.MoveRotation(wholeRb2d.rotation - rotationSpeed * Time.deltaTime * rotate);
            Vector2 delta = speed * Time.deltaTime * moveForward * wholeRb2d.transform.up;
            wholeRb2d.MovePosition(wholeRb2d.position + delta);
            if (moveForward > 0.1)
            {
                onHydraMove?.Invoke(wholeRb2d.position);
            }
        }
    
        public static float Rotate
        {
            set => rotate = value;
        }

        public static float MoveForward
        {
            set => moveForward = value;
        }
    }
}
