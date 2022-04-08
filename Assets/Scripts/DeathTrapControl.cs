using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using Unity.FPS.Game;

public class DeathTrapControl : MonoBehaviour
{
    public UnityEvent OnEnterEvent;
    public UnityEvent OnExitEvent;

    public float damage;

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
        Damageable damageable = other.GetComponent<Damageable>();
        if(damageable != null)
        {
            damageable.InflictDamage(damage, false, gameObject);
        }

        OnEnterEvent.Invoke();
    }

    private void OnTriggerStay(Collider other)
    {

    }

    private void OnTriggerExit(Collider other)
    {

        OnExitEvent.Invoke();
    }
}
