using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameSort : MonoBehaviour
{
    public GameObject ballBlue, ballRed;
    public GameObject shuteSpawn, shuteBlue, shuteRed;

    public int balls = 3;
    int ballsLeft;

    void Start()
    {
        
    }

    void Update()
    {
        if (ballsLeft <= balls)
        {
            //Instantiate(ballBlue);
        }
    }
}
