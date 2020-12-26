using System;
using System.Diagnostics;
using Pathfinding;
using UnityEngine;
using UnityEngine.PlayerLoop;
using Debug = UnityEngine.Debug;

namespace Enemies
{
    [RequireComponent(typeof(Enemy))]
    public class Ballistra : MonoBehaviour
    {
        [Header("Ballistra Attributes")]
        [Tooltip("Magenta Gizmo")][SerializeField] private float closeRange=15f;
        [Tooltip("Cyan Gizmo")][SerializeField] private float farRange=25f;
        [SerializeField] private Transform bulletSpawnpoint;
        [SerializeField] private GameObject bulletPrefab;
        [SerializeField] private float bulletSpeed;

        private Enemy thisEnemy;
        private AIPath aiPath;
        private Animator animator;
        private EnemyGFX enemyGfx;
        private int startFiringTriggerID;

        public enum State
        {
            Moving,
            Aiming,
            Firing
        }
        public State CurrentState { get; set; }

        private void Start()
        {
            aiPath = GetComponent<AIPath>();
            animator = GetComponent<Animator>();
            thisEnemy = GetComponent<Enemy>();
            enemyGfx = GetComponentInChildren<EnemyGFX>();
            
            thisEnemy.onChangedTarget.AddListener(ChangedTarget);
            CurrentState = State.Moving;
            aiPath.slowdownDistance = farRange;
            aiPath.endReachedDistance = closeRange;
            startFiringTriggerID = Animator.StringToHash("StartFiring");
        }

        private void Update()
        {
            switch (CurrentState)
            {
                case State.Aiming:
                    enemyGfx.enabled = false;
                    if (Vector2.Distance(transform.position, thisEnemy.CurrentTarget.position) <= farRange)
                    {
                        Aim();
                    }
                    else
                        CurrentState = State.Moving;
                    break;
                case State.Firing:
                    enemyGfx.enabled = false;
                    break;
                case State.Moving:
                    aiPath.canSearch = true;
                    aiPath.canMove = true;
                    enemyGfx.enabled = true;
                    if (aiPath.reachedEndOfPath)
                    {
                        aiPath.canSearch = false;
                        aiPath.canMove = false;
                        CurrentState = State.Aiming;
                    }
                    break;
            }

        }

        private void Aim()
        {
            Vector2 dir = (thisEnemy.CurrentTarget.position - enemyGfx.transform.position).normalized;
            enemyGfx.transform.rotation = Quaternion.Lerp(enemyGfx.transform.rotation, 
                Quaternion.LookRotation(Vector3.forward, dir), enemyGfx.RotationSpeed*Time.deltaTime);
            
            if (Mathf.Abs(Vector2.Dot(dir, enemyGfx.transform.up)) > 0.9999f)
            {
                animator.SetTrigger(startFiringTriggerID);
                CurrentState = State.Firing;
            }
        }

        private void Fire()
        {
            GameObject bullet = Instantiate(bulletPrefab, bulletSpawnpoint.position, bulletSpawnpoint.rotation);
            bullet.GetComponent<Rigidbody2D>().AddRelativeForce(bulletSpeed * Vector2.up, ForceMode2D.Impulse);
        }

        private void AimState()
        {
            CurrentState = State.Aiming;
        }

        private void ChangedTarget()
        {
            aiPath.canSearch = true;
            aiPath.canMove = true;
            CurrentState = State.Aiming;
        }

        private void OnDrawGizmosSelected()
        {
            Gizmos.color = Color.magenta;
            Gizmos.DrawWireSphere(transform.position, closeRange);
            
            Gizmos.color = Color.cyan;
            Gizmos.DrawWireSphere(transform.position, farRange);
        }
    }
}