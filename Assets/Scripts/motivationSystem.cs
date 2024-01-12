using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class motivationSystem : MonoBehaviour
{

    public float currentMotivation = 200f;
    public float motivationDropper = 5f;
    public float motivationIncreaser = 1f;
    public bool canDecrease;
    public bool canIncrease;
    public Slider motivationSlider;

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