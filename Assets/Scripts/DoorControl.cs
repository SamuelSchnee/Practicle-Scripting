using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DoorControl : MonoBehaviour
{
    public UnityEvent OnOpenDoorEvent;
    public UnityEvent OnCloseDoorEvent;

    public GameObject doorObj;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OpenDoor()
    {
        doorObj.SetActive(false);

        OnOpenDoorEvent.Invoke();
    }

    public void CloseDoor()
    {
        doorObj.SetActive(true);

        OnCloseDoorEvent.Invoke();
    }

}
