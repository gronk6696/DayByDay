using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cleaningGame : MonoBehaviour
{
    public GameObject CleaningPanel;
    public GameObject physicalObject;
    public int itemsCleaned = 0;
    public int itemsNeededCleaned;

    void Start()
    {
        CleaningPanel.SetActive(true);
    }


    void Update()
    {
        if (itemsCleaned == itemsNeededCleaned)
        {
            physicalObject.SetActive(false);
            CleaningPanel.SetActive(false);
        }
    }

    public void ItemCleaned()
    {
        itemsCleaned++;
    }
}
