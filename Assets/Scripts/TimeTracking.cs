using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Linq;

public class TimeTracking : MonoBehaviour
{
    public TMP_Text textTimer, promptBed;

    private float timer;
    public bool doTime;
    public List<string> randomLocations = new List<string>();
    public string location;
    public GameObject spacePrompt;

    public bool morning;
    public bool exitAble;
    public GameObject timeSkipAnim;

    public GameObject playerCharacter;
    


    private void Start()
    {
        timeSkipAnim.SetActive(false);
        doTime = true; 
        promptBed.enabled = false;
        morning = true;
        randomLocations.Add("therapy");
        randomLocations.Add("college");
        randomLocations.Add("work");

        SelectRandomWord();
        timer = 420.0f;
        //timer = 530.0f;
    }

    void Update()
    {
        if (doTime)
        {
            timer += Time.deltaTime;
            DisplayTime();
        }
       
        if (timer >= 540 && morning == true)
        {
            exitAble = true;
            promptBed.enabled = true;
            spacePrompt.SetActive(false);
            promptBed.text = "go to " + location + ".";
            if (timer >= 560)//ADD IN HERE OR THE DOOR INTERACT IS TRUE
            {
                Debug.Log("change");
                StartCoroutine(timeChange());
                
            }
        }

        if (timer >= 1320)
        {
            promptBed.enabled = true;
            promptBed.text = "go to bed";
        }
    }

    void DisplayTime()
    {
            int minutes = Mathf.FloorToInt(timer / 60.0f);
            int seconds = Mathf.FloorToInt(timer - minutes * 60);
            textTimer.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }



    void SelectRandomWord()
    {
        int randomIndex = Random.Range(0, randomLocations.Count);
        location = randomLocations[randomIndex];
    }

    IEnumerator timeChange()
    {
        exitAble = false;
        Debug.Log("Changed");
        promptBed.enabled = false;
        timeSkipAnim.SetActive(true);
        morning = false;
        timer = 1200.0f;
        doTime = false;
        yield return new WaitForSeconds(7.0f);
        timeSkipAnim.SetActive(false);
        //TURN ON EVENING OBJECTS
        playerCharacter.transform.position = new Vector3(0, 1, 4.79f);
        doTime = true;
        
    }



}
