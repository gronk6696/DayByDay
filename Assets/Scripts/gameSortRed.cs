using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameSortRed : MonoBehaviour
{
    public int scoreSort;

    void Start()
    {

    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "ballRed")
        {
            scoreSort++;
            Destroy(col.gameObject);
        }
        else if (col.gameObject.tag == "ballBlue")
        {
            Destroy(col.gameObject);
        }
    }
}
