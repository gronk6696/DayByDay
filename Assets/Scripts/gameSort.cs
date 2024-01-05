using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class gameSort : MonoBehaviour
{
    public GameObject ballBlue, ballRed;
    public GameObject shuteSpawn, shuteBlue, shuteRed;

    public float spawnInterval = 2f;
    //amount of balls dropped each time you play the minigame
    public int balls = 4;
    int ballsLeft;

    void Start()
    {
        ballsLeft = balls;

        StartCoroutine(SpawnBalls());
    }

    IEnumerator SpawnBalls()
    {
        for (int i = 0; i < balls; i++)
        {
            SpawnBall();
            yield return new WaitForSeconds(spawnInterval);
        }

        // end of minigame
        ScoreLogic();
    }

    void Update()
    {

    }

    void SpawnBall()
    {
        float randomValue = Random.Range(0f, 1f);

        if (randomValue < 0.5f)
        {
            Instantiate(ballRed, shuteSpawn.transform.position, shuteSpawn.transform.rotation);
        }
        else
        {
            Instantiate(ballBlue, shuteSpawn.transform.position, shuteSpawn.transform.rotation);
        }

        ballsLeft -= 1;
    }

    private void ScoreLogic()
    {
        //if balls sorted correctly, boost to motivation? otherwise negative motivation
    }
}
