using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepetitiveMapObject : MonoBehaviour
{
    private float mapLength;
    private float halfLength;

    // Start is called before the first frame update
    void Start()
    {
        mapLength = GameManager.Instance.mapLength;
        halfLength = mapLength/2;
    }

    // Update is called once per frame
    void Update()
    {
        var positionX = gameObject.transform.position.x;
        if (positionX > halfLength || positionX < -halfLength)
        {
            transform.position = new Vector3(positionX - Mathf.Sign(positionX)*mapLength, transform.position.y, 0);
        }
    }
}
