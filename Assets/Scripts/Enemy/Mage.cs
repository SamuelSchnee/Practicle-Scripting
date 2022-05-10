using System.Collections;
using System.Collections.Generic;
using Unity.FPS.Game;
using UnityEngine;

public class Mage : Enemy
{
    public Transform castLocation;
    public GameObject fireballPrefab;
    public float forceStrength;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("Cast", attackCooldown);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public override void Attack(Damageable damageable)
    {
        Cast();
    }

    public void Cast()
    {
        GameObject fireball = Instantiate(fireballPrefab, 
            castLocation.position, castLocation.rotation);

        Rigidbody fireBallBody = fireball.GetComponent<Rigidbody>();

        Vector3 direction = castLocation.forward + (castLocation.up * 0.15f);
        direction = direction * forceStrength;

        fireBallBody.AddForce(direction, ForceMode.Impulse);

        // Set Fireball damage
        CannonBall cannonball = fireball.GetComponent<CannonBall>();
        cannonball.damage = attackDamage;

        Invoke("Cast", attackCooldown);
    }
}
