using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.FPS.Game;

public class Enemy : MonoBehaviour
{
    public float attackDamage;
    public float attackCooldown;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public virtual void Attack(Damageable damageable)
    {
        Debug.Log("Attack has not been implmented");
    }
}
