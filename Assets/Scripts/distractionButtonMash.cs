using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class distractionButtonMash : MonoBehaviour
{
    public Slider distractionSlider;
    public GameObject distractionPanel;
    public GameObject timePanel;

    public GameObject distractionObject;


    public bool win;
    public float winLevel;
    void Start()
    {
        winLevel = 0;
        win = false;
        distractionObject.SetActive(false);
        timePanel.SetActive(false);
    }

    
    void Update()
    {
        distractionSlider.value = winLevel;
        if (winLevel > 0 && win == false && winLevel != 100)
        {
            winLevel = winLevel - Time.deltaTime * 8;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            winLevel = winLevel + 5;
        }

        if (winLevel > 99)
        {
            win = true;
            
        }

        if (win == true)
        {

            distractionPanel.SetActive(false);
            timePanel.SetActive(true);
            distractionObject.SetActive(true);
            winLevel = 0;
            win = false;
        }
    }
}
