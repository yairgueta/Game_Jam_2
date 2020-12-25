using System.Collections.Generic;
using Pathfinding;
using UnityEngine;

namespace Enemies
{
    public class EnemyGFX : MonoBehaviour
    {
        [SerializeField] private AIPath aiPath;
        [SerializeField] private float rotationSpeed = 3f;
        // Start is called before the first frame update
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
            var points = new List<Vector3>();
            aiPath.GetRemainingPath(points, out var state);

            if (points.Count <= 1) return;
        
            int i = 1;
            if (points.Count > 2) i = 2;
            Vector2 dir = (points[i] - transform.position).normalized; 
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(Vector3.forward, dir), Time.deltaTime * rotationSpeed);
        }
    }
}
