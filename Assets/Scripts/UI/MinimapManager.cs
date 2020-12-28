using System;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
    public class MinimapManager : MonoBehaviour
    { 
        private static Sprite[] minimapSprites;
        private Image maskImage;
        [SerializeField] private int speed = 2;

        private void Awake()
        {
            if (minimapSprites == null)
            {
                minimapSprites = Resources.LoadAll<Sprite>("MinimapSprites");
                // minimapSprites = minimapSprites.Union(minimapSprites.Reverse()).ToArray();
            }
            
        }

        private void Start()
        {
            maskImage = GetComponent<Image>();
            UpdateMap(Vector2.zero);
        }

        public void UpdateMap(Vector2 hydraPos)
        {
            var t = (hydraPos.x / GameManager.Instance.mapLength + 0.5f) * speed;
            maskImage.sprite = minimapSprites[(Mathf.RoundToInt(t * minimapSprites.Length)) % minimapSprites.Length];
            
        }
        

    }
}
