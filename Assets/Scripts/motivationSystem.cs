using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class motivationSystem : MonoBehaviour
{

    public float currentMotivation = 200f;
    public float motivationDropper = 0.5f;
    public float motivationIncreaser = 0.1f;
    public bool canDecrease;
    public bool canIncrease;

    // Start is called before the first frame update
    void Start()
    {
        canDecrease = true;
        canIncrease = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (canDecrease)
        {
            currentMotivation -= motivationDropper *Time.deltaTime;
        }

        if (canIncrease)
        {
            currentMotivation += motivationIncreaser * Time.deltaTime;
        }
    }
}