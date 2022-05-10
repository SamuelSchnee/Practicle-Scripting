using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : Puzzle
{
    public int colorNumber;

    public Renderer orbRenderer;
    public bool canChange;

    public int correctNumber;
    public bool rightColor;

    void Start()
    {
        orbRenderer = GetComponent<Renderer>();
        colorNumber = 1;
        canChange = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(colorNumber == correctNumber)
        {
            rightColor = true;
            solved = true;
            OnSolved.Invoke();
        }
        else
        {
            rightColor = false;
            solved = false;
        }
    }

    public void OnShot()
    {

        Debug.Log("gettingHit");

        if (canChange == true)
        {
            if (colorNumber < 5)
            {
                colorNumber++;
                canChange = false;
                Invoke("HitCooldown", 1);
            }
            else
            {
                colorNumber = 1;
                canChange = false;
                Invoke("HitCooldown", 1);
            }
        }

        if(colorNumber == 1)
        {
            gameObject.GetComponent<Renderer>().material.color = new Color(1, 1, 1);
        }
        if (colorNumber == 2)
        {
            gameObject.GetComponent<Renderer>().material.color = new Color(1, 0, 0);
        }
        if (colorNumber == 3)
        {
            gameObject.GetComponent<Renderer>().material.color = new Color(1, 1, 0);
        }
        if (colorNumber == 4)
        {
            gameObject.GetComponent<Renderer>().material.color = new Color(0, 1, 0);
        }
        if (colorNumber == 5)
        {
            gameObject.GetComponent<Renderer>().material.color = new Color(0, 0, 1);
        }
    }

    private void HitCooldown()
    {
        canChange = true;
    }
}
