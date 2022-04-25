using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shield : MonoBehaviour
{

    public bool shieldUnlocked;
    public GameObject shield;
    public bool shieldActive;
    public GameObject door;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.R) && shieldUnlocked == true && shield != null)
        {
            if(shieldActive == false)
            {
                shield.SetActive(true);
                shieldActive = true;
            }
            else
            {
                shield.SetActive(false);
                shieldActive = false;
            }
        }   
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "ShieldUnlock")
        {
            shieldUnlocked = true;
            Destroy(other.gameObject);
            Destroy(door);
        }
    }
}
