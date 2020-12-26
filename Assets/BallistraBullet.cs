using System;
using System.Collections;
using System.Collections.Generic;
using Enemies;
using UnityEngine;

public class BallistraBullet : MonoBehaviour, IDamageMaker
{
    [SerializeField] private float damage = 10f;
    [SerializeField] private float duration = 4f;
    
    public float Damage
    {
        get => damage;
        set => damage = value;
    }

    private void Start()
    {
        Destroy(gameObject, duration);
    }

    public float MakeDamage()
    {
        Destroy(gameObject);
        return damage;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        Destroy(gameObject);
    }
}
