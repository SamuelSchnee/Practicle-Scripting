using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.FPS.Gameplay;

public class JumpTrigger : MonoBehaviour
{
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
        if(other.tag == "Player")
        {
            PlayerCharacterController controller = other.gameObject.GetComponent<PlayerCharacterController>();

            //controller.AddForce(Vector3.up * 10 + Vector3.forward * 10, true);
        }
    }
}
