using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour, IDamageMaker
{
    [Header("Enemy Attributes")] 
    [SerializeField] private float maxHP = 50f;
    [SerializeField] private float bodyPower = 10f;
    [SerializeField] private float speed = 5f;

    [Header("References")]
    [SerializeField] private Image healthBarFiller;
    
    private float HP;

    void Start()
    {
        HP = maxHP;
    }

    public void Hit(float damage)
    {
        
        HP = Mathf.Clamp(HP - damage, 0, maxHP);
        healthBarFiller.fillAmount = HP / maxHP;

        HP = 0;
        if (HP == 0) Invoke(nameof(Die), .5f);
    }

    private void Die()
    {
        Destroy(gameObject);
    }

    public float MakeDamage()
    {
        Hit(maxHP);
        return bodyPower;
    }
}
