using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Wave
{
    public class WavesManager : MonoBehaviour
    {
        public static WavesManager Instance { get; private set; }
        
        public UnityEvent<int> onNewWaveStart;
        
        [SerializeField] private float timeBetweenWaves = 2f;
        private List<Wave> waves;
        private int currentWave = 0;

        private void Awake()
        {
            Instance = this;
        }

        private void Start()
        {
            waves = new List<Wave>();
            foreach (Transform child in transform)
            {
                Wave w = child.GetComponent<Wave>();
                if (w == null) continue;
                waves.Add(w);
                w.onWaveEnd += wave => CurrentWaveEnded();
            }
            waves.Sort();
            BeginWaves();
        }

        public void BeginWaves()
        {
            waves[0].StartWave();
        }

        private void CurrentWaveEnded()
        {
            currentWave++;
            if (currentWave == waves.Count)
            {
                GameManager.Instance.Win();
                return;
            }

            StartCoroutine(StartNextRound());
        }

        private IEnumerator StartNextRound()
        {
            onNewWaveStart?.Invoke(currentWave);
            yield return new WaitForSeconds(timeBetweenWaves);
            waves[currentWave].StartWave();
        }
    }
}