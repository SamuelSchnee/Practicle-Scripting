using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.FPS.Gameplay;
using UnityEngine.Events;

public class BouncePlatform : MonoBehaviour
{
    public float bounceForce;

    public UnityEvent OnTriggerEnterEvent;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        GameObject otherObject = collision.gameObject;

        Rigidbody body = otherObject.GetComponent<Rigidbody>();

        if(body != null)
        {
            Vector3 direction = gameObject.transform.up;

            direction = direction * bounceForce;

            body.AddForce(direction, ForceMode.Impulse);
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        GameObject otherObject = other.gameObject;

        Rigidbody body = otherObject.GetComponent<Rigidbody>();

        if (body != null)
        {
            Vector3 direction = gameObject.transform.up;

            direction = direction * bounceForce;

            body.AddForce(direction, ForceMode.Impulse);
        }

        if(otherObject.tag == "Player")
        {
            PlayerCharacterController controller = otherObject.GetComponent<PlayerCharacterController>();

            Vector3 direction = Vector3.up + Vector3.forward;

            direction = direction * bounceForce;

           // controller.AddForce(direction, true);
        }

        OnTriggerEnterEvent.Invoke();
    }


}
