using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.Controls;
using UnityEngine.UI;

public class FlamethrowerStation : Station
{
    [SerializeField] private GameObject flamethrowerObject;
    [SerializeField] private float maxAimAngle = 25f;
    [SerializeField] float aimSpeed = 100f;

    private float aimAngle;
    private float startAngle;

    private void Start()
    {
        startAngle = flamethrowerObject.transform.localRotation.eulerAngles.z;
        aimAngle = startAngle;
    }

    private void Update()
    {
        flamethrowerObject.transform.localRotation = Quaternion.Euler(0, 0, aimAngle);
    }

    protected override void EjectAction()
    {
        currentController?.ExitStation();
        flamethrowerObject.SetActive(false);
    }

    protected override void FireAction() { }

    protected override void HorizontalAction(float t)
    {
        aimAngle = Mathf.Clamp(aimAngle - t * Time.deltaTime* aimSpeed, startAngle - maxAimAngle, startAngle + maxAimAngle);
    }

    protected override void VerticalAction(float t)
    {
        flamethrowerObject.SetActive(t > .1f);
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        var pos = flamethrowerObject.transform.position;
        
        transform.rotation.ToAngleAxis(out var angle, out var axis);
        angle = angle * axis.z + maxAimAngle;
        Vector3 dir = new Vector2(Mathf.Cos(Mathf.Deg2Rad * angle), Mathf.Sin(Mathf.Deg2Rad * angle)).normalized;
        
        Gizmos.DrawLine(pos, pos + 3 * dir);
        Gizmos.DrawLine(pos, pos + Vector3.Reflect(3 * dir, transform.up));
    }
}
