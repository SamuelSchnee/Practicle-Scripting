using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.FPS.Gameplay;

public class Teleporter : MonoBehaviour
{
    public Transform teleportLocation;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void OnTriggerEnter(Collider other)
    {
        
        Vector3 teleportPos = teleportLocation.position;

        GameObject otherObject = other.gameObject;

        if (otherObject.tag == "Player")
        {
            CharacterController playerCtrl = otherObject.GetComponent<CharacterController>();

            playerCtrl.enabled = false;

            otherObject.transform.position = teleportPos;

            playerCtrl.enabled = true;

        }
        
    }

    
}
