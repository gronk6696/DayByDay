using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;

public class motivationSystem : MonoBehaviour
{

    public float currentMotivation = 200f;
    public float motivationDropper = 1f;
    public float motivationIncreaser = 1f;
    public bool canDecrease;
    public bool canIncrease;
    public Slider motivationSlider;

    public GameObject timePanel;
    public GameObject endGame;
    public GameObject spacePrompt;

    // Start is called before the first frame update
    void Start()
    {
        canDecrease = true;
        canIncrease = true;
    }

    // Update is called once per frame
    void Update()
    {
        motivationSlider.value = currentMotivation;
        if (canDecrease)
        {
            currentMotivation -= motivationDropper *Time.deltaTime;
        }

        if (canIncrease)
        {
            currentMotivation += motivationIncreaser * Time.deltaTime;
        }


        if(currentMotivation < 0)
        {
            timePanel.SetActive(false);
            endGame.SetActive(true);
        }
    }

    

    public void startCountdown()
    {
        StartCoroutine(Countdown(20));
    }



    IEnumerator Countdown(int seconds)
    {
        int counter = seconds;
        canIncrease = false;
        while (counter > 0)
        {
            yield return new WaitForSeconds(1);
            counter--;
        }
        canIncrease = true;
    }
}