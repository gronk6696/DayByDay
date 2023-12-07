using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class playerInteract : MonoBehaviour
{
    public TextMeshProUGUI uiPromptSpace;

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
        else
        {
            uiPromptSpace.enabled = false;
        }
    }

    void Start()
    {
        uiPromptSpace.enabled = false;
    }
}
