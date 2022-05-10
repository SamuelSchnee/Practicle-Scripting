using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Pickupable : MonoBehaviour
{
    Collider collider;
    Rigidbody body;

    Transform holdLocation;

    PlayerPickup holder;

    // Start is called before the first frame update
    void Start()
    {
        collider = gameObject.GetComponent<Collider>();
        body = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Pickup(GameObject sender)
    {
        if (holder == null)
        {
            body.isKinematic = true;
            collider.isTrigger = true;

            holder = sender.GetComponent<PlayerPickup>();
            holder.PickupObject(gameObject);
        }
        else
        {
            Drop();
        }
    }

    public void Drop()
    {
        body.isKinematic = false;
        collider.isTrigger = false;

        holder.DropObject();
        holder = null;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(holder != null)
        {
            Drop();
        }

    }


}
