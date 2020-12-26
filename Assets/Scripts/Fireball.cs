using System;
using Enemies;
using UnityEngine;

public class Fireball : MonoBehaviour
{
    [SerializeField] private float power = 30f;
    [SerializeField] private float duration = 3f;

    private void Awake()
    {
        transform.parent = EnemiesManager.Instance.transform;
        Destroy(this, duration);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Enemy hit = other.gameObject.GetComponent<Enemy>();
        hit?.GetHit(power);
        // TODO: Explosion Effect?
        Debug.Log(other.gameObject.name);
        Destroy(gameObject);
    }
}
