using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Interactable : MonoBehaviour
{
    public UnityEvent<GameObject> OnInteract;

    
    public void Interact(GameObject sender)
    {
        OnInteract.Invoke(sender);
    }

}
