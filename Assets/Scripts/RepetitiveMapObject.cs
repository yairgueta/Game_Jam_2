using System;
using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

public class RepetitiveMapObject : MonoBehaviour
{
    [SerializeField] private Transform enemies;
    [SerializeField] private CinemachineVirtualCamera cmCam;
    private float mapLength;
    private float halfLength;

    void Start()
    {
        mapLength = GameManager.Instance.mapLength;
        halfLength = mapLength/2;
    }

    void Update()
    {
        var positionX = gameObject.transform.position.x;
        if (positionX > halfLength || positionX < -halfLength)
        {
            ReflectAll(Math.Sign(positionX));
        }
    }

    void ReflectAll(int sign)
    {
        ReflectOne(gameObject.transform, sign);
        foreach (Transform e in enemies)
        {
            ReflectOne(e, sign);
        }
        cmCam.OnTargetObjectWarped(transform, new Vector3(- sign*mapLength, 0));

    }

    void ReflectOne(Transform t, int sign)
    {
        var posX = t.position.x;
        t.position = new Vector3(posX - sign*mapLength, t.position.y, 0);
    }
}
