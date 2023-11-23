using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Unity.VisualScripting;

public class buttonMashVisuals : MonoBehaviour
{

    public Slider visualSlider;

    public bool win;
    public float winLevel = 5;

    void Start()
    {
        visualSlider = GetComponent<Slider>();
    }

    void Update()
    {
        visualSlider.value = winLevel;
        if (winLevel > 0 && win == false) 
        {
            winLevel = winLevel - Time.deltaTime*2;
        }

        if (Input.GetKeyDown(KeyCode.E)) 
        {
            winLevel = winLevel + 3;
        }

        if (winLevel == 99)
        {
            win = true;
            winLevel = 100;
        }
    }
}
