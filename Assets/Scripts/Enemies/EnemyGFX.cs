using System;
using System.Collections.Generic;
using Pathfinding;
using UnityEngine;

namespace Enemies
{
    public class EnemyGFX : MonoBehaviour
    {
        [SerializeField] private AIPath aiPath;
        [SerializeField] private float rotationSpeed = 3f;

        public float RotationSpeed => rotationSpeed;

        void Update()
        {
            var points = new List<Vector3>();
            aiPath.GetRemainingPath(points, out var state);

            if (points.Count <= 1) return;
        
            int i = 1;
            if (points.Count > 2) i = 2;
            if (points.Count > 3) i = 3;
            Vector2 dir = (points[i] - transform.position).normalized;
            transform.localScale = new Vector3(Math.Sign(dir.x), 1, 1);
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(Vector3.forward, dir), Time.deltaTime * rotationSpeed);
        }
    }
}
