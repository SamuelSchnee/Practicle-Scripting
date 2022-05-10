using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteract : MonoBehaviour
{
    public Transform rayCastStartingPoint;
    public Transform rayCastDirection;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            Vector3 origin = rayCastStartingPoint.position;
            Vector3 direction = rayCastDirection.forward;

            RaycastHit hitInfo;

            bool hit = Physics.Raycast(origin, direction, out hitInfo, 1000);

            if (hit == true)
            {
                GameObject objHit = hitInfo.collider.gameObject;

                Interactable interactable = objHit.GetComponent<Interactable>();

                if(interactable != null)
                {
                    interactable.Interact(gameObject);
                }
            }
        }
    } 
}
