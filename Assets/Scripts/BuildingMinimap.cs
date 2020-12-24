using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingMinimap : MonoBehaviour
{
    private SpriteRenderer thisSp;
    private SpriteRenderer parentSp;
    
    // Start is called before the first frame update
    void Start()
    {
        thisSp = GetComponent<SpriteRenderer>();
        parentSp = transform.parent.GetComponent<SpriteRenderer>();
        thisSp.size = parentSp.size;
    }

}
