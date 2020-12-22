using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class NoStationMovement : Station
{
    [Header("Player Movement Attributes")]
    public float speed;

    private ContactPoint2D[] contactPoints;
    private int contactPointsNumber;
    private Vector2 movement;
    private Rigidbody2D rb2d;
    
    protected override void Start()
    {
        base.Start();
        contactPoints = new ContactPoint2D[3];
        rb2d = GetComponent<Rigidbody2D>();
        OnEjection += () => movement = Vector2.zero;
    }
    
    private void FixedUpdate()
    {
        var outForces = 1f;
        if (contactPointsNumber > 0)
        {
            Vector2 normal = contactPoints[0].normal.normalized;
            for (int i = 1; i < contactPointsNumber; i++)
            {
                normal += contactPoints[i].normal;
            }
            outForces = Vector2.Dot(movement.normalized, normal);
            movement -= outForces * (Vector2.Reflect(movement, normal).normalized);
        }
        Vector2 delta = speed * Time.fixedDeltaTime * movement.normalized;
        rb2d.MovePosition(rb2d.position + delta);
    }

    protected override void EjectAction() { }

    protected override void FireAction(){ }

    protected override void HorizontalAction(float t)
    {
        movement.x = t;
    }

    protected override void VerticalAction(float t)
    {
        movement.y = t;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        contactPointsNumber = other.GetContacts(contactPoints);
    }

    private void OnCollisionStay2D(Collision2D other)
    {
        contactPointsNumber = other.GetContacts(contactPoints);
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        contactPointsNumber = 0;
    }
}
