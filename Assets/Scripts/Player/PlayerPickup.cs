using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPickup : MonoBehaviour
{
    public Transform rayCastStartingPoint;
    public Transform rayCastDirection;
    public Transform pickupHoldPos;

    public float pushForce = 10.0f;

    GameObject objectHeld;

    PickUpable heldPickupCtrl;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //if we have an object, update its position
        if (objectHeld != null)
        {
            objectHeld.transform.position = pickupHoldPos.position;
            if(heldPickupCtrl.dropPickup == true)
            {
                heldPickupCtrl.Drop();
                heldPickupCtrl = null;
                objectHeld = null;
            }
        }

        //fire raycast to see if we can pick up an object
        if(Input.GetKeyDown(KeyCode.F))
        {
            if (objectHeld == null)
            {



                Vector3 origin = rayCastStartingPoint.position;
                Vector3 direction = rayCastDirection.forward;

                RaycastHit hitInfo;

                bool hit = Physics.Raycast(origin, direction, out hitInfo, 1000);

                if (hit == true)
                {
                    GameObject objHit = hitInfo.collider.gameObject;

                    heldPickupCtrl = objHit.GetComponent<PickUpable>(); 

                    if (heldPickupCtrl != null)
                    {
                        objectHeld = objHit;
                        heldPickupCtrl.Pickup();
                    }

                }
            }
            else
            {
                PickUpable pickupCtrl = objectHeld.GetComponent<PickUpable>();
                pickupCtrl.Drop();
                objectHeld = null;
              
            }
        }
    }

}
