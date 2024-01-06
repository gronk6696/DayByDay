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
    public int pointsScored;
    public int maxPoints = 5;

    public Camera minigameCamera;
    public Camera mainCamera;
    public bool gamePlay;

    int ballsLeft;

    void Start()
    {
        //ballsLeft = balls;

        
    }

    IEnumerator SpawnBalls()
    {
        for (int i = 0; i < maxPoints; i++)
        {
            SpawnBall();
            yield return new WaitForSeconds(spawnInterval);
        }

        // end of minigame
        ScoreLogic();
    }

    public void getPoint()
    {
        pointsScored++;
    }

    public void startGame()
    {
        Debug.Log("works");
        pointsScored = 0;
        StartCoroutine(SpawnBalls());
    }


    void Update()
    {
        if(maxPoints <= pointsScored)
        {
            minigameCamera.enabled = false;
            mainCamera.enabled = true;
        }
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

        //ballsLeft -= 1;
    }

    private void ScoreLogic()
    {
        //if balls sorted correctly, boost to motivation? otherwise negative motivation
    }
}
