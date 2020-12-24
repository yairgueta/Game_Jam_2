using System;
using System.Collections.Generic;
using System.Linq;
using Stations;
using UnityEngine;
using UnityEngine.Events;

namespace Hydra
{
    public class HydraHead : MonoBehaviour
    {
        public UnityEvent<float> onHydraHeadHit;
        public UnityEvent onHydraHeadDie;

        private static Dictionary<int, HydraHead> _idToHead;
        private static int _counter; 
        public int HeadID { get; private set; }
        
        [SerializeField] private float maxHP = 100;

        private Station station;
        private float HP;

        public static List<HydraHead> AllHeads => _idToHead.Values.ToList();

        public static HydraHead GetHead(int id)
        {
            return _idToHead[id];
        }

        private void Awake()
        {
            HeadID = HydraHead._counter++;
            _idToHead ??= new Dictionary<int, HydraHead>();
            _idToHead.Add(HeadID, this);
        }

        void Start()
        {
            station = GetComponent<Station>();
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
            // TODO: Destroy Animation?
            station.DisableStation();
            onHydraHeadDie?.Invoke();
        }

        private void OnCollisionEnter2D(Collision2D other)
        {
            IDamageMaker hit = other.gameObject.GetComponent<IDamageMaker>();
            if (hit != null)
            {
                GetHit(hit.MakeDamage());
            }
        }
    }
}
