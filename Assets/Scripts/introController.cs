using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Threading;

public class introController : MonoBehaviour
{
    public TextMeshProUGUI time7am;
    public TextMeshProUGUI time730am;
    public TextMeshProUGUI time8am;
    public AudioSource alarmSequence;
    public float timer5sec = 5;
    public float timer3sec = 3;
    public bool timer5needed;
    public bool timer3needed;
    public GameObject minigamePanel;
    public bool goto730;
    public bool goto8;
    public bool gotoMini;
    public bool happened7am;
    public bool happened730am;
    public bool happened8am;
    public bool happenedMinigame;
    
    // Start is called before the first frame update
    void Start()
    {
        time7am.enabled = false;
        time730am.enabled = false;
        time8am.enabled = false;
        minigamePanel.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timer5needed == true)
        {
            timer5sec = timer5sec - Time.deltaTime;
        }
        if (timer3needed == true)
        {
            timer3sec = timer3sec - Time.deltaTime;
        }

        if (timer5sec < 0)
        {
            timer5needed = false;
            timer5sec = 5;
        }

        if (timer3sec < 0)
        {
            timer3needed = false;
            timer3sec = 3;
        }
        if (gotoMini == true)
        {
            minigamePanel.SetActive(true);
        }
        StartSequence();
    }

    void StartSequence()
    {
        if (happened7am == false)
        {
            happened7am = true;
            time7am.enabled = true;
            alarmSequence.Play();
            timer5needed = true;
            timer3needed = true;
            if (timer3sec <= 1)
            {
                time7am.enabled = false;
                Debug.Log("hi");
            }
            if (timer5sec <= 1)
            {
                goto730 = true;
            }
            Debug.Log("yoooo");
        }

        if (happened730am == false)
        {
            happened730am = true;
            if (goto730 == true)
            {
                time730am.enabled = true;
                alarmSequence.Play();
                timer5needed = true;
                timer3needed = true;

                if (timer3sec < 1)
                {
                    time730am.enabled = false;
                }
                Debug.Log("why wont it work");

                if (timer5sec < 1)
                {
                    goto8 = true;
                    goto730 = false;
                }
                Debug.Log("yoooo2");
            }
        }

            if (happened8am == false)
            {
                happened8am = true;
                if (goto8 == true)
                {
                    time8am.enabled = true;
                    alarmSequence.Play();
                    timer5needed = true;
                    timer3needed = true;
                    if (timer3sec < 0)
                    { time8am.enabled = false; }
                    if (timer5sec < 0)
                    {
                        gotoMini = true;
                        goto8 = false;
                    }
                    Debug.Log("yoooo3");
                }
            }
        
        
        
    }
}
