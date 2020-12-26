using System;
using Hydra;
using Pathfinding;
using UnityEngine;
using UnityEngine.Events;

namespace Enemies
{
    [RequireComponent(typeof(AIDestinationSetter), typeof(AIPath))]
    public class Enemy : MonoBehaviour, IDamageMaker
    {
        public Action<Enemy> onThisEnemyDeath;
        [Header("References")]
        [SerializeField] private RectTransform healthBarFiller;
    
        [Header("AI Attributes")]
        [Tooltip("The time between targeting to the nearest hydra again")][SerializeField] private float hydraHeadTargetRefreshRate = 2f;

        [Header("Enemy Attributes")] 
        public UnityEvent onChangedTarget;
        [SerializeField] private float maxHP = 50f;
        [SerializeField] private float bodyPower = 10f;
        [SerializeField] private float speed = 5f;
        [SerializeField] private int score = 10;
        
        private AIPath aiPath;
        private HydraHead currentTarget;
        private AIDestinationSetter destinationSetter;
        private float HP;
        private Vector2 fillerOriginalSize;

        public Transform CurrentTarget => currentTarget.EnemiesTarget;
        public int Score => score;

        private void Start()
        {
            destinationSetter = GetComponent<AIDestinationSetter>();
            aiPath = GetComponent<AIPath>();
        
            HP = maxHP;
            fillerOriginalSize = healthBarFiller.sizeDelta;
            aiPath.maxSpeed = speed;
        
            InvokeRepeating(nameof(TargetClosestHydra), 0, hydraHeadTargetRefreshRate);
        }

        private void Update()
        {
            healthBarFiller.transform.parent.rotation = Quaternion.identity;
        }

        public void GetHit(float damage)
        {
            HP = Mathf.Clamp(HP - damage, 0, maxHP);
            healthBarFiller.sizeDelta = new Vector2((HP / maxHP) * fillerOriginalSize.x, fillerOriginalSize.y);
            if (HP == 0) Invoke(nameof(Die), .1f);
        }

        private void Die()
        {
            onThisEnemyDeath?.Invoke(this);
            EnemiesManager.Instance.onEnemyDeath?.Invoke(this);
            Destroy(gameObject);
        }

        public float MakeDamage()
        {
            GetHit(maxHP);
            return bodyPower;
        }

        private void TargetClosestHydra()
        {
            var heads = HydraHead.AllHeads;
            var curMinHead = heads[0];
            var curMinDist = Mathf.Infinity;

            foreach (var hydraHead in heads)
            {
                if (!hydraHead) return;
                if (!hydraHead.IsAlive) continue;
                var dist = Vector3.SqrMagnitude(transform.position - hydraHead.transform.position);
                if (!(dist < curMinDist)) continue;
                curMinHead = hydraHead;
                curMinDist = dist;
            }

            if (currentTarget == curMinHead) return;
            currentTarget = curMinHead;
            destinationSetter.target = currentTarget.EnemiesTarget;
            onChangedTarget?.Invoke();
        }
    }
}
