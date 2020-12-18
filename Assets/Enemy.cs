using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour, IEnemy
{
    [Header("Attributes")] 
    [SerializeField] private float maxHP = 50f;
    [SerializeField] private float power = 10f;
    [SerializeField] private Image healthBarFiller;
    
    private float HP;
    
    void Start()
    {
        HP = maxHP;
    }

    private void Update()
    {
        healthBarFiller.fillAmount = HP / maxHP;
    }

    public void Hit(float damage)
    {
        HP = Mathf.Clamp(HP - damage, 0, maxHP);
    }
}
