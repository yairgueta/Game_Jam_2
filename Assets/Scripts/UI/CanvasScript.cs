using UnityEngine;

namespace UI
{
    public class CanvasScript : MonoBehaviour
    {
        void Start()
        {
            SceneController.Instance.SetHelpButtons(transform.GetChild(0).gameObject, transform.GetChild(1).gameObject);
        }
    }
}
