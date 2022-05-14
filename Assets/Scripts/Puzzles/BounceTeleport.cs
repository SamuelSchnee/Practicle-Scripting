using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceTeleport : MonoBehaviour
{
    public PlayerTeleport playertele;
    public GameObject destination;
    public float boostStrength;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerStay(Collider other)
    {
        Debug.Log("onTeleporter");
        if (other.gameObject.tag == "Box" && playertele.canTeleport == true)
        {
            Debug.Log("teleporting");
            other.transform.position = destination.transform.position;
            Rigidbody boxRb = other.gameObject.GetComponent<Rigidbody>();
            boxRb.AddForce(Vector2.up * boostStrength, ForceMode.Impulse);
            playertele.canTeleport = false;
            Invoke("TeleportCooldown", 3f);
        }
    }

    private void TeleportCooldown()
    {
        playertele.canTeleport = true;
    }
}
