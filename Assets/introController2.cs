using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class introController2 : MonoBehaviour
{
    public TextMeshProUGUI text7am; 
    public TextMeshProUGUI text730am;
    public TextMeshProUGUI text8am;
    public GameObject minigameObject;
    private float timeToAppear = 3.5f;
    private float timeWhenDisappear;
    public AudioSource alarmNoise;
    public bool textOn7am;
    public bool textOn730am;
    public bool textOn8am;
    public bool minigamePanel;

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
    }
}
