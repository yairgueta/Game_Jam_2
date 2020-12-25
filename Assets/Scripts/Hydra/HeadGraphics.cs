using DG.Tweening;
using UnityEngine;

namespace Hydra
{
    [RequireComponent(typeof(HydraHead))]
    public class HeadGraphics : MonoBehaviour
    {
        [Header("Head OnDie Animation Settings")] 
        [SerializeField] private SpriteRenderer head;
        [SerializeField] private Gradient onDieHeadGradient;
        [SerializeField] private float headDieDuration = 1f;
    
        [Header("Coin OnDie Animation Settings")]
        [SerializeField] private SpriteRenderer coin;
        [SerializeField] private Gradient onDieCoinGradient;
        [SerializeField] private float coinDieDuration = 1f;
    
    
        void Start()
        {
            HydraHead head = GetComponent<HydraHead>();
            head.onHydraHeadDie.AddListener(OnDie_Head);
            head.onHydraHeadDie.AddListener(OnDie_Coin);
        }

        private void OnDie_Head()
        {
            head.DOGradientColor(onDieHeadGradient, headDieDuration);
        }
    
        private void OnDie_Coin()
        {
            coin.DOGradientColor(onDieCoinGradient, coinDieDuration);
        }
    }
}
