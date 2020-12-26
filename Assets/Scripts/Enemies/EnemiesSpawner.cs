using System;
using System.Collections.Generic;
using UnityEngine;

namespace Enemies
{
    public class EnemiesSpawner : MonoBehaviour
    {
        public static EnemiesSpawner Instance { get; private set; }
        public List<EnemiesSpawningPoint> SpawningPoints { get; private set; }

        private void Awake()
        {
            Instance = this;
            SpawningPoints = new List<EnemiesSpawningPoint>();
        }
        
    }
}