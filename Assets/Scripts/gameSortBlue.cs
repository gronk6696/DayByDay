using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameSortBlue : MonoBehaviour
{
    public int scoreSort;
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
        }
        else if (col.gameObject.tag == "ballRed")
        {
            Destroy(col.gameObject);
        }   
    }
}
