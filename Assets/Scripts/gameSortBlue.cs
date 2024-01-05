using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameSortBlue : MonoBehaviour
{
    public int scoreSort;

    void Start()
    {
        
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "ballBlue")
        {
            scoreSort++;
            Destroy(col.gameObject);
        }
        else if (col.gameObject.tag == "ballRed")
        {
            Destroy(col.gameObject);
        }   
    }
}
