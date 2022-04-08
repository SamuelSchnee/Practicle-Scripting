using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMoveControl : MonoBehaviour
{
    public float speed;

    public GameObject point1, point2;

    private GameObject target;

    int index;

    bool moveFlag;

    void Start()
    {
        target = point1;
        index = 0;
        moveFlag = false;
    }

    void Update()
    {
        if(moveFlag == true)
        {
            MoveObstacle();
        }
    }

    public void StartMove()
    {
        moveFlag = true;
    }

    public void StopMove()
    {
        moveFlag = false;
    }
    void MoveObstacle()
    {
        // moving the obstacle
        Vector3 direction = target.transform.position - transform.position;
        direction.Normalize();

        direction *= Time.deltaTime;

        direction *= speed;

        transform.position += direction;
        //////////////////////////////////////////////////////////
        ///check to see if it has reached the target
        ///
        float distance = Vector3.Distance(target.transform.position, transform.position);

        if (distance <= 1f)
        {
            if (index == 0)
            {
                target = point2;
                index = 1;
            }
            else if (index == 1)
            {
                target = point1;
                index = 0;
            }
        }
    }
}
