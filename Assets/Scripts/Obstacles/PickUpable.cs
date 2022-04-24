using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Rigidbody))]
public class PickUpable : MonoBehaviour
{
    Rigidbody body;
    Collider collider;

    public bool dropPickup;

    // Start is called before the first frame update
    void Start()
    {
        collider = GetComponent<Collider>();
        body = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Pickup()
    {
        body.isKinematic = true;
        collider.isTrigger = true;
    }

    public void Drop()
    {
        collider.isTrigger = false;
        body.isKinematic = false;

        dropPickup = false;
    }

   /* private void OnTriggerEnter(Collider other)
    {
        Debug.Log("hit something");
        dropPickup = true;
    }*/
}
