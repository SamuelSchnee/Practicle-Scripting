using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlateController : MonoBehaviour
{
    public DetectionScript detector;
    public GameObject door;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (detector.onPlate == true)
        {
            pressurePlateActive();
        }
    }

    void pressurePlateActive()
    {
        Destroy(door.gameObject);
    }
}
