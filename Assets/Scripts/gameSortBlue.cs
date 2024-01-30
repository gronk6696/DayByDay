using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameSortBlue : MonoBehaviour
{
    public gameSort gameSortScr;

    void Start()
    {
        
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "ballBlue")
        {
            gameSortScr.getPoint();
            Destroy(col.gameObject);
            Debug.Log("Score!");
        }
        else if (col.gameObject.tag == "ballRed")
        {
            Destroy(col.gameObject);
            Debug.Log("Miss!");
        }   
    }
}
