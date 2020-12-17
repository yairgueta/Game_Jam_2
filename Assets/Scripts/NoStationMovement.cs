using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class NoStationMovement : Station
{
    public float speed;

    private Vector3 movement;
        
        
    private Rigidbody2D rb2d;
    private void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        
        var playerInputController = GetComponent<PlayerInputController>();
        Inject(playerInputController);
    }

    private void FixedUpdate()
    {
        rb2d.MovePosition(transform.position + speed * movement.normalized * Time.fixedDeltaTime);
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
}
