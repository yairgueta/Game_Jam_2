using System;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.Events;
using Debug = UnityEngine.Debug;

namespace Enemies
{
    public class EnemiesManager : MonoBehaviour
    {
        public static EnemiesManager Instance { get; private set; }
        public UnityEvent<Enemy> onEnemyDeath;

        
        private void Awake()
        {
            Instance = this;
        }
        
        
        
    }
}