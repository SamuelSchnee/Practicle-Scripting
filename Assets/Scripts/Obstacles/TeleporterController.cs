using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleporterController : MonoBehaviour
{
    public PlayerTeleport playertele;
    public GameObject destination;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("onTeleporter");
        if(/*other.gameObject.tag == "Player" && */playertele.canTeleport == true)
        {
            Debug.Log("teleporting");
            other.transform.position = destination.transform.position;
            playertele.canTeleport = false;
            Invoke("TeleportCooldown", 3f);    
        }
    }

    private void TeleportCooldown()
    {
        playertele.canTeleport = true;
    }
}
