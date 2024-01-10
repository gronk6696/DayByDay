using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class introController2 : MonoBehaviour
{
    public TMP_Text timeText, getUpText,promptSpaceText;
    public GameObject slider;
    private float timeToAppear = 4f;
    private float timeWhenDisappear;
    public AudioSource alarmNoise;

    private void Start()
    {
        promptSpaceText.enabled = false;
        timeText.enabled = true;
        slider.SetActive(false);
        getUpText.enabled = false;
        StartCoroutine(introSequence());
    }

    IEnumerator introSequence()
    {
        timeText.text = "7:00";
        alarmNoise.Play();
        yield return new WaitForSeconds(timeToAppear);
        timeText.text = "7:30";
        alarmNoise.Play();
        yield return new WaitForSeconds(timeToAppear);
        timeText.text = "8:00";
        alarmNoise.Play();
        yield return new WaitForSeconds(timeToAppear);
        timeText.enabled = false;
        slider.SetActive(true);
        getUpText.enabled=true;
        promptSpaceText.enabled = true;
    }


    /*
    public void Start()
    {
        minigameObject.SetActive(false);
    }

    public void EnableText7am()
    {
        text7am.enabled = true;
        timeWhenDisappear = Time.time + timeToAppear;
        alarmNoise.Play();  
    }

    public void EnableText730am()
    {
        text730am.enabled = true;
        timeWhenDisappear = Time.time + timeToAppear;
        alarmNoise.Play();
    }

    public void EnableText8am()
    {
        text8am.enabled = true;
        timeWhenDisappear = Time.time + timeToAppear;
        alarmNoise.Play();
    }

    void Update()
    {

        if (textOn7am == true)
        {
            EnableText7am();
            textOn7am = false;
        }

        if (textOn730am == true)
        {
            EnableText730am();
            textOn730am = false;
        }

        if (textOn8am == true)
        {
            EnableText8am();
            textOn8am = false;
        }

        if (text7am.enabled && (Time.time >= timeWhenDisappear))
        {
            text7am.enabled = false;            
        }

        if (text730am.enabled && (Time.time >= timeWhenDisappear))
        {
            text730am.enabled = false;
        }

        if (text8am.enabled && (Time.time >= timeWhenDisappear))
        {
            text8am.enabled = false;
        }

        if (minigamePanel == true)
        {
            minigameObject.SetActive(true);
        }
    }*/
}
