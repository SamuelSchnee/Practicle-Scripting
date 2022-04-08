using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPush : MonoBehaviour
{
    [SerializeField]
    float pushStrength = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        Rigidbody body = hit.collider.attachedRigidbody;

        if(body != null)
        {
            Vector3 pushDirection = hit.gameObject.transform.position
                - gameObject.transform.position;
            pushDirection.y = 0;
            pushDirection.Normalize();

            pushDirection *= pushStrength;

            body.AddForceAtPosition(pushDirection,
                gameObject.transform.position, ForceMode.Impulse);
        }


    }

}
