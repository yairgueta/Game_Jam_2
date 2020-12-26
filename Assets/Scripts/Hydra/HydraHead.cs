using System;
using System.Collections.Generic;
using System.Linq;
using Enemies;
using Stations;
using UnityEngine;
using UnityEngine.Events;

namespace Hydra
{
    public class HydraHead : MonoBehaviour
    {
        private static Dictionary<int, HydraHead> _idToHead = new Dictionary<int, HydraHead>();
        private static int _counter;
        
        public UnityEvent<float> onHydraHeadHit;
        public UnityEvent onHydraHeadDie;
        
        public int HeadID { get; private set; }
        public bool IsAlive { get; private set; }
        public Transform EnemiesTarget => enemiesTarget;
        
        [SerializeField] private float maxHP = 100;
        [SerializeField] private Transform enemiesTarget;
        private Station station;
        private float HP;

        public static List<HydraHead> AllHeads => _idToHead.Values.ToList();

        public static HydraHead GetHead(int id)
        {
            return _idToHead[id];
        }

        public static void ResetHeads()
        {
            _idToHead = new Dictionary<int, HydraHead>();
            _counter = 0;
        }

        private void Awake()
        {
            HeadID = HydraHead._counter++;
            _idToHead.Add(HeadID, this);
        }

        void Start()
        {
            station = GetComponent<Station>();
            IsAlive = true;
            HP = maxHP;
        }

        private void GetHit(float power)
        {
            HP = Mathf.Clamp(HP - power, 0, maxHP);

            onHydraHeadHit?.Invoke(HP / maxHP);
            // TODO: Update health UI
            if (HP == 0)
            {
                Die();
            }
        }

        private void Die()
        {
            station.DisableStation();
            onHydraHeadDie?.Invoke();
            IsAlive = false;
        }

        private void OnCollisionEnter2D(Collision2D other)
        {
            if (!IsAlive) return;
            IDamageMaker hit = other.gameObject.GetComponent<IDamageMaker>();
            if (hit != null)
            {
                GetHit(hit.MakeDamage());
            }
        }
    }
}
