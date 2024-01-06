using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameSortRed : MonoBehaviour
{
    public int scoreSort;
    public gameSort gameSortScr;

    void Start()
    {
        //gameSortScr = GetComponent<gameSort>();
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "ballRed")
        {
            gameSortScr.getPoint();
            Destroy(col.gameObject);
        }
        else if (col.gameObject.tag == "ballBlue")
        {
            Destroy(col.gameObject);
        }
    }
}
