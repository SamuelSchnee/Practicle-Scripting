using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using Unity.FPS.Game;

public class CannonBall : MonoBehaviour
{
    public UnityEvent OnHit;

    public float damage;
    public bool destroySelfOnHit;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter(Collision collision)
    {
        OnHit.Invoke();

        GameObject objectHit = collision.gameObject;

        Damageable damageable = objectHit.gameObject.GetComponent<Damageable>();

        if (damageable != null)
        {
            damageable.InflictDamage(damage, false, gameObject);
        }

        if (destroySelfOnHit)
        {
            Health health = gameObject.GetComponent<Health>();
            if (health != null)
            {
                health.Kill();
            }
            else
            {
                Destroy(gameObject);
            }
        }

        

    }



}
