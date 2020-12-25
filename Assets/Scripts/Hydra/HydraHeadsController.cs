using UnityEngine;
using UnityEngine.Events;

namespace Hydra
{
    public class HydraHeadsController : MonoBehaviour
    {
        public UnityEvent onAllHeadsDeath;
    
        private int headsCount;
        private int aliveCount;

        void Start()
        {
            foreach (var head in HydraHead.AllHeads)
            {
                headsCount++;
                head.onHydraHeadDie.AddListener(OnHydraHeadDie_Controller);
            }
            aliveCount = headsCount;
        }

        private void OnHydraHeadDie_Controller()
        {
            aliveCount--;
            if (aliveCount == 0)
            {
                onAllHeadsDeath?.Invoke();
            }
        }
    }
}
