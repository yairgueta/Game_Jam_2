using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireball : MonoBehaviour
{
    [SerializeField] private float power = 30f;

    private void OnTriggerEnter2D(Collider2D other)
    {
        IEnemy hit = other.gameObject.GetComponent<IEnemy>();
        hit?.Hit(power);
        // Explosion Effect?
        Destroy(gameObject);
    }
}
