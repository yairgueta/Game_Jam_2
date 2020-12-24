using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireballStation : Station
{
    [Header("Fireball Attributes")]
    [SerializeField] private GameObject fireballPrefab;
    [SerializeField] private Transform spawnPoint;
    [SerializeField] private float fireForce = 100f;

    [Header("Aiming Attributes")] 
    [SerializeField] private GameObject hydraHead;
    [SerializeField] private float maxAimAngle = 25f;
    [SerializeField] float aimSpeed = 100f;

    private float aimAngle;
    private AudioSource fireSound;
    
    protected override void Start()
    {
        base.Start();
        stationType = StationTypeEnum.Aiming;
        aimAngle = 0;
        fireSound = GetComponent<AudioSource>();
    }

    private void Update()
    {
        hydraHead.transform.localRotation = Quaternion.Euler(0, 0, aimAngle);
    }

    protected override void EjectAction()
    {
        currentController?.ExitStation();
    }

    protected override void FireAction()
    {
        //Fire
        Rigidbody2D fireballRb2d = Instantiate(fireballPrefab, spawnPoint.position, spawnPoint.rotation).GetComponent<Rigidbody2D>();
        fireballRb2d.AddForce(spawnPoint.up*fireForce, ForceMode2D.Impulse);
        fireSound.Play();
        
    }

    protected override void HorizontalAction(float t)
    {
        // Aim
        aimAngle = Mathf.Clamp(aimAngle - t * Time.deltaTime* aimSpeed,  -maxAimAngle, maxAimAngle);
    }

    protected override void VerticalAction(float t) { }
    
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        var pos = hydraHead.transform.position;
        
        transform.rotation.ToAngleAxis(out var angle, out var axis);
        angle = 90 + angle * axis.z + maxAimAngle;
        Vector3 dir = new Vector2(Mathf.Cos(Mathf.Deg2Rad * angle), Mathf.Sin(Mathf.Deg2Rad * angle)).normalized;
        
        Gizmos.DrawLine(pos, pos + 3 * dir);
        Gizmos.DrawLine(pos, pos + Vector3.Reflect(3 * dir, transform.right));
    }
}
