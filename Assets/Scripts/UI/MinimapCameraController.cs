using UnityEngine;

namespace UI
{
    public class MinimapCameraController : MonoBehaviour
    {
        private Transform mainCamera;
        private float oy, oz;
        void Start()
        {
            mainCamera = Camera.main.gameObject.transform;
            oy = transform.position.y;
            oz = transform.position.z;
        }

        private void LateUpdate()
        {
            transform.position = new Vector3(mainCamera.position.x, oy, oz);
        }
    }
}
