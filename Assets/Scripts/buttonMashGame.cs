using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;

public class buttonMashGame : MonoBehaviour
{
    public Slider gameSlider;
    public GameObject gamePanel;
    public GameObject physicalObject;


    public bool win;
    public float winLevel;
    void Start()
    {
        winLevel = 0;
        win = false;
        physicalObject.SetActive(false);
    }


    void Update()
    {
        gameSlider.value = winLevel;
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
            gamePanel.SetActive(false);
        }

    }
}
