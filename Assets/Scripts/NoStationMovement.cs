using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class NoStationMovement : Station
{
    public float speed;

    private Vector2 movement;
        
    private Rigidbody2D rb2d;
    private void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        Vector2 delta = speed * Time.fixedDeltaTime * movement.normalized;
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


    protected override void OnTriggerEnter2D(Collider2D other) { }
}
