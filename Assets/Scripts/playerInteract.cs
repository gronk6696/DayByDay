using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class playerInteract : MonoBehaviour
{
    public motivationSystem motivationSystem;
    public TextMeshProUGUI uiPromptSpace;
    public GameObject buttonGamePanel;
    public GameObject timePanel;

    private Animation staticAnimation;
    public GameObject staticPanel;

    public GameObject phonePanel;
    public GameObject phoneObject;

    public GameObject TVPanel;
    public GameObject TVObject;

    public GameObject laptopPanel;
    public GameObject laptopObject;

    void OnTriggerStay(Collider col)
    {
        if (col.gameObject.tag == "interact")
        {
            uiPromptSpace.enabled = true;
            //Debug.Log("Near interactable");
            if (Input.GetKey(KeyCode.Space))
            {
                Destroy(col.gameObject);
                uiPromptSpace.enabled = false;
                //Debug.Log("Interacted");
            }
        }
        else if (col.gameObject.tag == "buttonGame")
        {
            uiPromptSpace.enabled = true;
            Debug.Log("Near interactable");
            if (Input.GetKey(KeyCode.Space))
            {
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
            Debug.Log("working");
            uiPromptSpace.enabled = true;
            if (Input.GetKey(KeyCode.Space))
            {
                phonePanel.SetActive(true);
                motivationSystem.GetComponent<motivationSystem>().startCountdown();
                phoneObject.SetActive(false);
            }
        }
        else if (col.gameObject.tag == "television")
        {
            uiPromptSpace.enabled = true;
            if(Input.GetKey(KeyCode.Space))
            {
                TVPanel.SetActive(true);
                motivationSystem.GetComponent<motivationSystem>().startCountdown();
                TVObject.SetActive(false);
            }
        }
        else if (col.gameObject.tag == "laptop")
        {
            uiPromptSpace.enabled = true;
            if(Input.GetKey(KeyCode.Space))
            {
                laptopPanel.SetActive(true);
                motivationSystem.GetComponent <motivationSystem>().startCountdown();
                laptopObject.SetActive(false);
            }
        }
        else
        {
          uiPromptSpace.enabled = false;
        }
    }
    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "buttonGame" || col.gameObject.tag == "interact" || col.gameObject.tag == "phone" || col.gameObject.tag == "television" || col.gameObject.tag == "laptop")
        {
            uiPromptSpace.enabled = false;
            phoneObject.SetActive(true);
            TVObject.SetActive(true);
            laptopObject.SetActive(true);
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
        
    }

    private void Update()
    {
        if (phonePanel.activeInHierarchy == true)
        {

        }
    }
}
