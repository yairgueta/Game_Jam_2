using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider2D))]
public class TriggerActionInvoker : MonoBehaviour
{
    public Action<Collider2D> OnTriggerAction;

    private void OnTriggerEnter2D(Collider2D other)
    {
        OnTriggerAction?.Invoke(other);
    }
}
