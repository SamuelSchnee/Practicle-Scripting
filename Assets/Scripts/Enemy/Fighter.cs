using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.FPS.Game;
using UnityEngine.AI;

public class Fighter : Enemy
{
    NavMeshAgent agent;
    float cooldownTimer;

    public GameObject target;


    // Start is called before the first frame update
    void Start()
    {
        agent = gameObject.GetComponent<NavMeshAgent>();
        cooldownTimer = attackCooldown;

    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(target.transform.position);
    }

    public override void Attack(Damageable damageable)
    {
        if (damageable != null)
        {
            damageable.InflictDamage(attackDamage, false, gameObject);
        }
    }


    private void OnTriggerStay(Collider other)
    {
        if (cooldownTimer <= 0.0f)
        {
            GameObject otherObject = other.gameObject;

            if (otherObject.tag == "Player")
            {
                Damageable damageable = otherObject.GetComponent<Damageable>();
                Attack(damageable);
            }

            cooldownTimer = attackCooldown;
        }
        else
        {
            cooldownTimer = cooldownTimer - Time.deltaTime;
        }

    }

}
