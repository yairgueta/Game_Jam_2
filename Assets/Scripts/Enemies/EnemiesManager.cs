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

        public int EnemiesCount { get; set; }
        private int deadEnemies;
        
        private void Awake()
        {
            Instance = this;
            onEnemyDeath.AddListener((e) =>
            {
                deadEnemies++;
                Debug.Log(deadEnemies + "/" + EnemiesCount);
                if (deadEnemies == EnemiesCount)
                    GameManager.Instance.Win();
            });
        }
        
        
        
    }
}