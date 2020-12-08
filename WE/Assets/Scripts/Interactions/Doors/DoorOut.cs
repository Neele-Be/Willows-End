
using UnityEngine;

public class DoorOut : Interactable
{
    public GameObject target;
    
    public override void Interact()
    {
        SceneControl.TransitionPlayer(target.transform.position);
    }
}
