using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HydraMovement : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    [SerializeField] private float rotationSpeed = 3f;
    // [SerializeField] private GameObject hydraBody;
    
    private Rigidbody2D wholeRb2d;
    private static float rotate;
    private static float moveForward;

    private void Start()
    {
        wholeRb2d = GetComponent<Rigidbody2D>();
    }
    
    private void FixedUpdate()
    {
        wholeRb2d.MoveRotation(wholeRb2d.rotation -rotationSpeed * Time.deltaTime * rotate);
        Vector2 delta = speed * Time.deltaTime * moveForward * wholeRb2d.transform.right;
        wholeRb2d.MovePosition(wholeRb2d.position + delta);
    }
    
    public static float Rotate
    {
        set => rotate = value;
    }

    public static float MoveForward
    {
        set => moveForward = value;
    }
}
