using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonController : MonoBehaviour
{
    public GameObject cannonBallPrefab;
    public GameObject spawnPoint;

    public float startDelay = 3.0f;
    public float spawnRate;
    public float spawnForce;
    float timer;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("FireCannon", startDelay, spawnRate);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void FireCannon()
    {
        Vector3 spawnPos = spawnPoint.transform.position;

        Quaternion rot = cannonBallPrefab.transform.rotation;

        GameObject cannonBallInst = Instantiate(cannonBallPrefab, spawnPos, rot);

        Rigidbody cannonBallBody = cannonBallInst.GetComponent<Rigidbody>();

        Vector3 launchDirection = spawnPoint.transform.forward;

        launchDirection *= spawnForce;

        cannonBallBody.AddForce(launchDirection, ForceMode.Impulse);
    }
}
