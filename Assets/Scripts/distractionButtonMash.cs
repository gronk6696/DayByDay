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

    public bool win;
    public float winLevel;
    void Start()
    {
        
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
            winLevel = 100;
            distractionPanel.SetActive(false);

        }
    }
}
