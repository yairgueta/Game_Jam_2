using System;
using System.Linq;
using UnityEngine;

namespace Hydra
{
    [RequireComponent(typeof(HydraHead))]
    public class HydraHealth : MonoBehaviour
    {
        [SerializeField] private GameObject healthFiller;
        private HydraHead hydraHead;

        private float maxYFiller;

        private void Awake()
        {
            hydraHead = GetComponent<HydraHead>();
            maxYFiller = healthFiller.transform.localScale.y;
        }

        private void Start()
        {
            hydraHead.onHydraHeadHit.AddListener(HealthChange);
        }

        private void HealthChange(float hpPercentage)
        {
            var fillerScale = healthFiller.transform.localScale;
            fillerScale.y = maxYFiller * hpPercentage;
            healthFiller.transform.localScale = fillerScale;
        }
    }
}
