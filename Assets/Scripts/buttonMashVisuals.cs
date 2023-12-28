using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Unity.VisualScripting;
using UnityEngine.SceneManagement;
using JetBrains.Annotations;
using System.Linq;


public class buttonMashVisuals : MonoBehaviour
{

    public Slider visualSlider;
    public GameObject endPanel;

    public bool win;
    public float winLevel = 0;

    void Start()
    {
        visualSlider = GetComponent<Slider>();
        endPanel.SetActive(false);
    }

    void Update()
    {
        visualSlider.value = winLevel;
        if (winLevel > 0 && win == false && winLevel != 100) 
        {
            winLevel = winLevel - Time.deltaTime*8;
        }

        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            winLevel = winLevel + 5;
        }

        if (winLevel > 99)
        {
            win = true;
            winLevel = 100;
            endPanel.SetActive(true);
            SceneManager.LoadScene("Apartment");
        }
    }
}
