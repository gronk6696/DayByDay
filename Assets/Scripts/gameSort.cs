using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameSort : MonoBehaviour
{
    public GameObject ballBlue, ballRed;
    public GameObject shuteSpawn, shuteBlue, shuteRed;

    public float spawnInterval = 2f;

    public int balls = 4;
    int ballsLeft;

    void Start()
    {
        // InvokeRepeating(methodName, timeDelay, repeatRate)
        if (ballsLeft <= balls)
        {
            InvokeRepeating("SpawnBall", 0.0f, spawnInterval);
        }
        else if (ballsLeft == 0)
        {
            ScoreLogic();
        }

    }

    void SpawnBall()
    {
        // Instantiate the object at the spawner's position and rotation
        Instantiate(ballBlue, shuteSpawn.transform.position, shuteSpawn.transform.rotation);
        ballsLeft -= 1;
    }

    void Update()
    {

    }



    private void ScoreLogic()
    {
        //if balls sorted correctly, boost to motivation? otherwise negative motivation
    }
}
