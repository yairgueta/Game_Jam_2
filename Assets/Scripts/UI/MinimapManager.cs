using System;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
    public class MinimapManager : MonoBehaviour
    {

        private Sprite[] minimapSprites;
        private Image maskImage;

        private void Start()
        {
            maskImage = GetComponent<Image>();
            minimapSprites = Resources.LoadAll<Sprite>("MinimapSprites");
            UpdateMap(Vector2.zero);
        }

        public void UpdateMap(Vector2 hydraPos)
        {
            var t = hydraPos.x / GameManager.Instance.mapLength + 0.5f;
            maskImage.sprite = minimapSprites[Mathf.RoundToInt(t * minimapSprites.Length) % minimapSprites.Length];
            
        }
        

    }
}
