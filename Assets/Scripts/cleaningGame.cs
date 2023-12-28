using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cleaningGame : MonoBehaviour
{
    public GameObject CleaningPanel;
    public int itemsCleaned = 0;

    void Start()
    {
        
    }


    void Update()
    {
        if (itemsCleaned == 6)
        {
            CleaningPanel.SetActive(false);
        }
    }

    public void ItemCleaned()
    {
        itemsCleaned++;
    }
}
