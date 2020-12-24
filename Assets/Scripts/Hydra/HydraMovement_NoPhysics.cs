using System;
using System.Collections;
using System.Collections.Generic;
using Stations;
using UnityEngine;
using UnityEngine.InputSystem;

public class HydraMovement_NoPhysics : Station
{
    [SerializeField] private float playerRotationSpeed = 200f;
    [SerializeField] private float playerSpeed = 0.1f;

    public Transform movePoint;
    public LayerMask whatStopsMovement;
    
    [HideInInspector] public Action OnEjectKey;
    private Vector3 moveVector;
    private float move;
    private float rotation;

    void Start()
    {
        moveVector = Vector3.zero;
    }

    private void FixedUpdate()
    {
        HandleInput();
        SceneController.Instance.SetActiveHelpButtons(SceneController.Player.Player1,SceneController.Role.Movement,true);
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

    protected override void EjectAction()
    {
        OnEjectKey?.Invoke();
    }

    protected override void FireAction() { }

    protected override void HorizontalAction(float t)
    {
        rotation = t;
    }

    protected override void VerticalAction(float t)
    {
        move = Mathf.Clamp01(t);
    }
}
