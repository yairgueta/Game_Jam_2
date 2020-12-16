using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class HydraMovementScript : MonoBehaviour
{
    [SerializeField] private float playerRotationSpeed;
    [SerializeField] private float playerSpeed;

    private float move;
    public Transform movePoint;
    private Vector3 moveVector;
    public LayerMask whatStopsMovement;
    private float rotation;


    // Start is called before the first frame update
    void Start()
    {
        playerRotationSpeed = 200f;
        playerSpeed = 0.1f;
        moveVector = Vector3.zero;
    }

    public void OnRotate(InputAction.CallbackContext context)
    {
        rotation = context.ReadValue<float>();
    }
    public void OnForward(InputAction.CallbackContext context)
    {
        move = context.ReadValue<float>();
        Debug.Log(context.ReadValue<float>());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        HandleInput();
    }


    private void HandleInput()
    {
        moveVector = GetDirectionFromAngle()*playerSpeed;
        if (rotation < 0)
        {
            if (!Physics2D.OverlapCircle(movePoint.position + Vector3.left, .2f, whatStopsMovement))
            {
                transform.eulerAngles = transform.eulerAngles + new Vector3(0, 0, .5f) * Time.fixedDeltaTime * playerRotationSpeed;
            }
        }
        else if (rotation > 0)
        {
            if (!Physics2D.OverlapCircle(movePoint.position + Vector3.right, .2f, whatStopsMovement))
            {
                transform.eulerAngles = transform.eulerAngles + new Vector3(0, 0, -.5f) * Time.fixedDeltaTime * playerRotationSpeed;
            }
        }
        if (move > 0)
        {
            transform.position = Vector3.MoveTowards(transform.position,movePoint.position, playerSpeed * Time.fixedDeltaTime);
            if (Vector3.Distance(transform.position, movePoint.position) <= .05f)
            {
                if (!Physics2D.OverlapCircle(movePoint.position + moveVector, .2f, whatStopsMovement))
                {
                    movePoint.position += moveVector;
                }
            }
        }
    }
    private Vector3 GetDirectionFromAngle()
    {
        float angle = transform.eulerAngles.z * Mathf.Deg2Rad*-1;
        float sin = Mathf.Sin(angle);
        float cos = Mathf.Cos(angle);
        return new Vector3(sin ,  cos , 0f);
    }
}
