using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;

public class HydraLight : MonoBehaviour
{
    [SerializeField] private Light2D light;
    [SerializeField] private Vector2 intencities;
    [SerializeField] private float speed;

    private void Update()
    {
        
        light.intensity = intencities.x + Mathf.PingPong(Mathf.PerlinNoise(Time.time*speed, 0), intencities.y - intencities.x);
    }
}
