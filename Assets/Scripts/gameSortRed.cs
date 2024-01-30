using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameSortRed : MonoBehaviour
{
    public gameSort gameSortScr;

    void Start()
    {

    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "ballRed")
        {
            gameSortScr.getPoint();
            Destroy(col.gameObject);
            Debug.Log("Score!");
        }
        else if (col.gameObject.tag == "ballBlue")
        {
            Destroy(col.gameObject);
            Debug.Log("Miss!");
        }
    }
}
