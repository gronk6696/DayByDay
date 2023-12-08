using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class playerInteract : MonoBehaviour
{
    public TextMeshProUGUI uiPromptSpace;
    public GameObject buttonGamePanel;

    void OnTriggerStay(Collider col)
    {
        if (col.gameObject.tag == "interact")
        {
            uiPromptSpace.enabled = true;
            Debug.Log("Near interactable");
            if (Input.GetKey(KeyCode.Space))
            {
                Destroy(col.gameObject);
                uiPromptSpace.enabled = false;
                Debug.Log("Interacted");
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
        else
        {
          uiPromptSpace.enabled = false;
        }
    }
    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "interact")
        {
            uiPromptSpace.enabled = false;
        }
        else if (col.gameObject.tag == "buttonGame")
        {
            uiPromptSpace.enabled = false;
        }
    }

    void Start()
    {
        uiPromptSpace.enabled = false;
        buttonGamePanel.SetActive(false);
    }
}
