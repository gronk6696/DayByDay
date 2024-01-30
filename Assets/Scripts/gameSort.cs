using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class gameSort : MonoBehaviour
{
    public GameObject sortGameCamera;
    public GameObject mainCamera;

    public bool gamePlay;

    public GameObject shuteSpawn;
    public GameObject ballBlue, ballRed;

    public float spawnInterval = 2f;
    public int TotalBallsToDrop;
    public int pointsScored;
    public int pointsNeededToWin;


    void Start()
    {
        
    }

    public void startGame()
    {
        StartCoroutine(SpawnBalls());
        pointsScored = 0;
    }

    public IEnumerator SpawnBalls()
    {
        for (int i = 0; i < TotalBallsToDrop; i++)
        {
            InstantiateBall();
            
            yield return new WaitForSeconds(spawnInterval);
        }

        //end of minigame
        GameComplete();
    }

    public void getPoint()
    {
        pointsScored++;
    }

    public void InstantiateBall()
    {
        //Debug.Log("spawning balls");
        float randomValue = Random.Range(0f, 1f);

        if (randomValue < 0.5f)
        {
            Instantiate(ballRed, shuteSpawn.transform.position, shuteSpawn.transform.rotation);
        }
        else
        {
            Instantiate(ballBlue, shuteSpawn.transform.position, shuteSpawn.transform.rotation);
        }
    }

    private void GameComplete()
    {
        if(pointsScored >= pointsNeededToWin)
        {
            Debug.Log("you win :D"); 
        }
        else
        {
            Debug.Log("you lose! Fuck you!");
        }

        sortGameCamera.SetActive(false);
        mainCamera.SetActive(true);
    }
}
