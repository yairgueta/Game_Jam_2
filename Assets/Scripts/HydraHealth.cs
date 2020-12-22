using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.InputSystem.Controls;

[RequireComponent(typeof(Collider2D))]
public class HydraHealth : MonoBehaviour
{
    public Action OnHydraHeadDie;
    
    [SerializeField] private float maxHP = 100;
    [SerializeField] private HydraHeadStatus[] headStatuses = new HydraHeadStatus[1];
    [SerializeField] private SpriteRenderer headSpriteRenderer;
    private Station station;
    private float HP;
    private int currentHeadStatusIndex;
    private float HealthPercentage => HP / maxHP;
    
    void Start()
    {
        station = GetComponent<Station>();
        HP = maxHP;
        Array.Sort(headStatuses);
        currentHeadStatusIndex = 0;
        if (headStatuses.Last().healthPercentage != 0)
            Debug.LogWarning("Hydra Health Component named " + gameObject.name + " does not end with 0%");
    }

    private void GetHit(float power)
    {
        HP = Mathf.Clamp(HP - power, 0, maxHP);
        UpdateHeadStatus();

        // TODO: Update health UI
        if (HP == 0)
        {
            Die();
        }
    }

    private void UpdateHeadStatus()
    {
        HydraHeadStatus status = headStatuses.ElementAtOrDefault(currentHeadStatusIndex);
        if (status == null) return;
        if (status.healthPercentage < HealthPercentage) return;

        headSpriteRenderer.sprite = headStatuses[currentHeadStatusIndex].statusSprite;
        // TODO: Switch animation?
        currentHeadStatusIndex++;


    }

    private void Die()
    {
        // TODO: Destroy Animation?
        station.DisableStation();
        OnHydraHeadDie?.Invoke();
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        Enemy hit = other.gameObject.GetComponent<Enemy>();
        if (hit != null)
        {
            hit.Hit(Mathf.Infinity);
            GetHit(hit.Power);
        }
    }
    
    
    [Serializable]
    public class HydraHeadStatus : IComparable<HydraHeadStatus>
    {
        public float healthPercentage;
        public Sprite statusSprite;
        

        public int CompareTo(HydraHeadStatus other)
        {
            return Math.Sign(other.healthPercentage - healthPercentage);
        }
    }

}
