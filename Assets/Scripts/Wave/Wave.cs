using System;
using Enemies;
using UnityEngine;

namespace Wave
{
    
    public class Wave : MonoBehaviour, IComparable<Wave>
    {
        public Action<Wave> onWaveEnd;
        [SerializeField] int waveNumber;
        private int enemiesCount;
        private int deathCount;

        private void Start()
        {
            foreach (Transform child in transform)
            {
                Enemy e = child.GetComponent<Enemy>();
                if (e == null) continue;
                enemiesCount++;
                e.onThisEnemyDeath += o =>
                {
                    deathCount++;
                    if (deathCount == enemiesCount)
                    {
                        EndWave();
                    }
                };
            }
        }

        public void StartWave()
        {
            gameObject.SetActive(true);
        }
        
        private void EndWave()
        {
            onWaveEnd?.Invoke(this);
        }
        

        public int CompareTo(Wave other)
        {
            if (ReferenceEquals(this, other)) return 0;
            if (ReferenceEquals(null, other)) return 1;
            return waveNumber - other.waveNumber;
        }
    }
}