using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootToMove : MonoBehaviour
{
    public GameObject player;
    public float shotForce;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Shot()
    {
        Rigidbody cubeRb = gameObject.GetComponent<Rigidbody>();
        Vector3 playerDirection = player.transform.forward;
        playerDirection.Normalize();
        cubeRb.AddForce(playerDirection * shotForce, ForceMode.Impulse);
    }
}
