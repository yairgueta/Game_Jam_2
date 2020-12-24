using System;
using System.Linq;
using UnityEngine;

namespace Hydra
{
    [RequireComponent(typeof(Collider2D), typeof(HydraHead))]
    public class HydraHealth : MonoBehaviour
    {
        [SerializeField] private HydraHeadStatus[] headStatuses = new HydraHeadStatus[1];
        [SerializeField] private SpriteRenderer headSpriteRenderer;

        private HydraHead hydraHead;
        private int currentHeadStatusIndex;

        private void Awake()
        {
            hydraHead = GetComponent<HydraHead>();
            Array.Sort(headStatuses);
            currentHeadStatusIndex = 0;
            if (headStatuses.Last().healthPercentage != 0)
                Debug.LogWarning("Hydra Health Component named " + gameObject.name + " does not end with 0%");
        }

        private void Start()
        {
            hydraHead.onHydraHeadHit.AddListener(UpdateHeadStatus);
        }

        private void UpdateHeadStatus(float hpPercentage)
        {
            HydraHeadStatus status = headStatuses.ElementAtOrDefault(currentHeadStatusIndex);
            if (status == null) return;
            if (status.healthPercentage < hpPercentage) return;

            headSpriteRenderer.sprite = headStatuses[currentHeadStatusIndex].statusSprite;
            // TODO: Switch animation?
            currentHeadStatusIndex++;
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
}
