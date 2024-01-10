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
    public TMP_Text getUpText;
    public Slider visualSlider;
    public bool goToApartment;
    public GameObject doBetterPanel;

    public bool win;
    public float winLevel = 0;

    void Start()
    {
        visualSlider = GetComponent<Slider>();
        doBetterPanel.SetActive(false);
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
            StartCoroutine(winGame());
        }
    }

    IEnumerator winGame()
    {
        getUpText.enabled = false;
        doBetterPanel.SetActive (true);
        yield return new WaitForSeconds(2.0f);
        SceneManager.LoadScene("Apartment");
    }
}
