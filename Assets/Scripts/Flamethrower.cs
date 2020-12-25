using System;
using System.Collections;
using System.Collections.Generic;
using Enemies;
using UnityEngine;

public class Flamethrower : MonoBehaviour
{
    [SerializeField] private float power;
    
    private void OnTriggerStay2D(Collider2D other)
    {
        Enemy enemy = other.GetComponent<Enemy>();
        enemy?.GetHit(power * Time.fixedDeltaTime);
        // TODO: Damage effect?
    }
}
