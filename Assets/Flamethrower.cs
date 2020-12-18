using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flamethrower : MonoBehaviour
{
    [SerializeField] private float power;
    
    
    private void OnTriggerStay2D(Collider2D other)
    {
        Debug.Log(other.gameObject.name);
        IEnemy enemy = other.GetComponent<IEnemy>();
        enemy?.Hit(power * Time.fixedDeltaTime);
    }
}
