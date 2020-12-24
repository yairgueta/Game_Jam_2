using UnityEngine;

public class Fireball : MonoBehaviour
{
    [SerializeField] private float power = 30f;

    private void OnTriggerEnter2D(Collider2D other)
    {
        Enemy hit = other.gameObject.GetComponent<Enemy>();
        hit?.GetHit(power);
        // TODO: Explosion Effect?
        Destroy(gameObject);
    }
}
