using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMovement : MonoBehaviour
{
    public Rigidbody boxRb;
    public Vector3 currentPosition;

    // Start is called before the first frame update
    void Start()
    {
        boxRb = GetComponent<Rigidbody>();

        float z = transform.position.z;

        Debug.Log(z);

        //transform.position = new Vector3(transform.position.x, 100, transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        currentPosition = transform.position;

        Vector3 direction = new Vector3(0, 1, 0);

        direction *= Time.deltaTime;

        currentPosition += direction;

        transform.position = currentPosition;
    }
}
