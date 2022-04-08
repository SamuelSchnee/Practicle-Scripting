using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.FPS.Game;

public class LaserControl : MonoBehaviour
{
    LineRenderer lineRend;
    public LayerMask hitMask;
    public float laserLength = 10.0f;
    public float damagePerTick = 1.0f;
    [Range(0.01f, 5.0f)]
    public float damageSpeed = 1.0f;
    public GameObject hitEffect;

    float timer;

    // Start is called before the first frame update
    void Start()
    {
        lineRend = GetComponentInChildren<LineRenderer>();
        timer = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        // set line renderer positions
        lineRend.SetPosition(0, gameObject.transform.position);

        RaycastHit hitInfo;
        bool hit = Physics.Raycast(transform.position, transform.forward, out hitInfo, laserLength, hitMask);

        if(hit)
        {
            lineRend.SetPosition(1, hitInfo.point);
            hitEffect.transform.position = hitInfo.point;


            timer = timer - Time.deltaTime;
            if (timer < 0)
            {
                Damageable damageable = hitInfo.collider.gameObject.GetComponent<Damageable>();

                if (damageable != null)
                {
                    damageable.InflictDamage(damagePerTick, false, gameObject);
                    timer = damageSpeed;
                }
            }
        }
        else
        {
            Vector3 endPoint = gameObject.transform.position + (gameObject.transform.forward * laserLength);
            lineRend.SetPosition(1, endPoint);
            hitEffect.transform.position = endPoint;

            timer = 0.0f;
        }

    }
}
