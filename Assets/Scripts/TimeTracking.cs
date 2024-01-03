using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimeTracking : MonoBehaviour
{
    public TMP_Text textTimer, promptBed;

    private float timer = 1425.0f;
    private bool isTimer = false;
    

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        DisplayTime();
    }

    void DisplayTime()
    {
        if (timer <= 1440)
        {
            int minutes = Mathf.FloorToInt(timer / 60.0f);
            int seconds = Mathf.FloorToInt(timer - minutes * 60);
            textTimer.text = string.Format("{0:00}:{1:00}", minutes, seconds);
            promptBed.enabled = false;
        }
        else if (timer > 1440)
        {
            int minutes = Mathf.FloorToInt((timer - 1440) / 60.0f);
            int seconds = Mathf.FloorToInt((timer - 1440) - minutes * 60);
            textTimer.text = string.Format("{0:00}:{1:00}", minutes, seconds);
            promptBed.enabled = true;
        }
    }

    public void StartTimer()
    {
        isTimer = true;
    }

    public void StopTimer()
    {
        isTimer = false;
    }

    public void ResetTimer()
    {
        timer = 0.0f;
    }


}
