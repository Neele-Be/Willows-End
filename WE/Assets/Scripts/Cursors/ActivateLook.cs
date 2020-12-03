using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateLook : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseEnter()
    {
        CursorController.instance.ActivateLook();
    }

    private void OnMouseExit()
    {
        CursorController.instance.ActivatePointer();
    }
}
