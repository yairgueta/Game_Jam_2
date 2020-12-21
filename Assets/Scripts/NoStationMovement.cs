using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class NoStationMovement : Station
{
    public float speed;

    private Vector2 movement;
    private Rigidbody2D rb2d;
    private float radius;
    
    protected override void Start()
    {
        base.Start();
        rb2d = GetComponent<Rigidbody2D>();
        radius = GetComponent<CircleCollider2D>().radius;
    }

    private void FixedUpdate()
    {
        var dir = movement.normalized;
        Vector2 delta = speed * Time.fixedDeltaTime * dir;
        // if (!Physics2D.CircleCast(rb2d.position, radius, dir, radius,~(1<<3)))
            rb2d.MovePosition(rb2d.position + delta);
        movement = Vector2.zero;
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
        Debug.Log(other.gameObject.name);
    }
}
