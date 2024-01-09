using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Runtime.InteropServices;

public class playerInteract : MonoBehaviour
{
    public motivationSystem motivationSystem;
    public TextMeshProUGUI uiPromptSpace;
    public GameObject buttonGamePanel;
    public GameObject timePanel;

    private Animation staticAnimation;
    public GameObject staticPanel;

    public GameObject phonePanel;
    public GameObject TVPanel;
    public GameObject laptopPanel;

    public Camera sortGameCamera;
    public Camera mainCamera;
    public gameSort gameScoreStart;

    void OnTriggerStay(Collider col)
    {
        if (col.gameObject.tag == "interact")
        {
            uiPromptSpace.enabled = true;
            if (Input.GetKey(KeyCode.Space))
            {
                Destroy(col.gameObject);
                uiPromptSpace.enabled = false;
            }
        }
        else if (col.gameObject.tag == "buttonGame")
        {
            uiPromptSpace.enabled = true;
            if (Input.GetKey(KeyCode.Space))
            {
                uiPromptSpace.enabled = false;
                buttonGamePanel.SetActive(true);
                uiPromptSpace.enabled = false;
            }
        }
        else if (col.gameObject.tag == "knife")
        {
            staticPanel.SetActive(true);

        }
        else if (col.gameObject.tag == "phone")
        {
            uiPromptSpace.enabled = true;
            if (Input.GetKey(KeyCode.Space))
            {
                uiPromptSpace.enabled = false;
                phonePanel.SetActive(true);
                motivationSystem.GetComponent<motivationSystem>().startCountdown();
            }
        }
        else if (col.gameObject.tag == "television")
        {
            uiPromptSpace.enabled = true;
            if (Input.GetKey(KeyCode.Space))
            {
                uiPromptSpace.enabled = false;
                TVPanel.SetActive(true);
                motivationSystem.GetComponent<motivationSystem>().startCountdown();
            }
        }
        else if (col.gameObject.tag == "laptop")
        {
            uiPromptSpace.enabled = true;
            if (Input.GetKey(KeyCode.Space))
            {
                uiPromptSpace.enabled = false;
                laptopPanel.SetActive(true);
                motivationSystem.GetComponent<motivationSystem>().startCountdown();
            }
        }
        else if (col.gameObject.tag == "sortGame")
        {
            uiPromptSpace.enabled = true;
            if (Input.GetKey(KeyCode.Space))
            {
                uiPromptSpace.enabled = false;
                //gameScoreStart.startGame();
                sortGameCamera.enabled = true;
                mainCamera.enabled = false;
                gameScoreStart.startGame();
            }
        }

        else if (col.gameObject.tag == "door")
        {

        }
        else
        {
          uiPromptSpace.enabled = false;
        }
    }
    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "buttonGame" || col.gameObject.tag == "interact" || col.gameObject.tag == "phone" || col.gameObject.tag == "television" || col.gameObject.tag == "laptop" || col.gameObject.tag == "sortGame")
        {
            uiPromptSpace.enabled = false;
        }
        else if (col.gameObject.tag == "knife")
        {
            staticPanel.SetActive(false);
        }
    }
        
    

    void Start()
    {
        uiPromptSpace.enabled = false;
        buttonGamePanel.SetActive(false);
        staticPanel.SetActive(false);
        phonePanel.SetActive(false);
        TVPanel.SetActive(false);
        laptopPanel.SetActive(false);
        sortGameCamera.enabled = false;
        
    }

    private void Update()
    {
        if (phonePanel.activeInHierarchy == true || laptopPanel.activeInHierarchy == true || TVPanel.activeInHierarchy == true)
        {
            //somehow have WASD turn off
        }
    }
}
