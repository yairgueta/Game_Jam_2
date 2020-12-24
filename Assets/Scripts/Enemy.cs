using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Hydra;
using Pathfinding;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(AIDestinationSetter), typeof(AIPath))]
public class Enemy : MonoBehaviour, IDamageMaker
{
    [Header("References")]
    [SerializeField] private RectTransform healthBarFiller;
    
    [Header("AI Attributes")]
    [Tooltip("The time between targeting to the nearest hydra again")][SerializeField] private float hydraHeadTargetRefreshRate = 2f;
 
    [Header("Enemy Attributes")] 
    [SerializeField] private float maxHP = 50f;
    [SerializeField] private float bodyPower = 10f;
    [SerializeField] private float speed = 5f;

    private AIDestinationSetter destinationSetter;
    private AIPath aiPath;
    private float HP;
    private Vector2 fillerOriginalSize;
    private HydraHead currentTarget;

    void Start()
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
        var rect = healthBarFiller.rect;
        healthBarFiller.sizeDelta = new Vector2((HP / maxHP) * fillerOriginalSize.x, fillerOriginalSize.y);
        if (HP == 0) Invoke(nameof(Die), .1f);
    }

    private void Die()
    {
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
        var curMinDist = Vector3.SqrMagnitude(transform.position - curMinHead.transform.position);

        for (var i = 1; i < heads.Count; i++)
        {
            var hydraHead = heads[i];
            var dist = Vector3.SqrMagnitude(transform.position - hydraHead.transform.position);
            if (!(dist < curMinDist)) continue;
            curMinHead = hydraHead;
            curMinHead = hydraHead;
        }

        currentTarget = curMinHead;
        destinationSetter.target = currentTarget.transform;

    }
}
