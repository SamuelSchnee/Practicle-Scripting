using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPickup : MonoBehaviour
{
    public Transform holdlocation;

    GameObject heldObject;
    Pickupable pickupCtrl;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(heldObject != null)
        {
            heldObject.transform.position = holdlocation.transform.position;
        }

    }

    public void PickupObject(GameObject pickup)
    { 
        if (heldObject == null)
        {
            heldObject = pickup;
        }
        else
        {
            DropObject();
        }
    }

    public void DropObject()
    {
        if(heldObject != null)
        {
            //pickupCtrl.Drop();
            pickupCtrl = null;
            heldObject = null;
        }

    }

}
