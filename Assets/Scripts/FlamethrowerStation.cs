using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlamethrowerStation : Station
{
    [SerializeField] private GameObject flamethrowerObject;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    protected override void EjectAction()
    {
        currentController?.ExitStation();
    }

    protected override void FireAction() { }

    protected override void HorizontalAction(float t)
    {
        // Aim
    }

    protected override void VerticalAction(float t)
    {
        flamethrowerObject.SetActive(t > .1f);
    }
    
    
}
