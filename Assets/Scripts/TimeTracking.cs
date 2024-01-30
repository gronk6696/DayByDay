using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Linq;
using UnityEngine.SceneManagement;

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
    public bool bedAble;
    public bool hasExited;
    public bool hasBeded;
    public GameObject timeSkipAnim;
    public GameObject bedTimeSkipAnim;

    public GameObject playerCharacter;
    public playerInteract playerInteractScript;

    //game objects for each chore
    public GameObject microwaveAM;
    public GameObject bathroomSinkAM;
    public GameObject showerAM;
    public GameObject trashAM;
    public GameObject dishesAM;
    public GameObject dustAM;

    public GameObject microwavePM;
    public GameObject bathroomSinkPM;
    public GameObject showerPM;
    public GameObject trashPM;
    public GameObject dishesPM;
    public GameObject dustPM;

    public Material skybox2;


    private void Start()
    {
        timeSkipAnim.SetActive(false);
        bedTimeSkipAnim.SetActive(false);
        doTime = true; 
        promptBed.enabled = false;
        morning = true;
        randomLocations.Add("therapy");
        randomLocations.Add("college");
        randomLocations.Add("work");

        SelectRandomWord();
        timer = 420.0f;
        //timer = 530.0f;

        microwavePM.SetActive(false);
        bathroomSinkPM.SetActive(false);
        showerPM.SetActive(false);
        trashPM.SetActive(false);
        dishesPM.SetActive(false);
        dustAM.SetActive(false);
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
            playerInteractScript.canLeave = true;
            exitAble = true;
            promptBed.enabled = true;
            spacePrompt.SetActive(false);
            promptBed.text = "go to " + location + ".";
            if (timer >= 560 || hasExited == true)//ADD IN HERE OR THE DOOR INTERACT IS TRUE
            {
                Debug.Log("change");
                StartCoroutine(timeChange());
                
            }
        }

        if (timer >= 1320)
        {
            playerInteractScript.canBed = true;
            promptBed.enabled = true;
            promptBed.text = "go to bed";
            bedAble = true;
            spacePrompt.SetActive(false);
            if(timer >= 1340 || hasBeded == true)//add in here or bed interact is true
            {
                StartCoroutine(gameFinish());
            }

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
        RenderSettings.skybox = skybox2;
        timer = 1200.0f;
        doTime = false;
        yield return new WaitForSeconds(10.0f);
        timeSkipAnim.SetActive(false);
        //TURN ON EVENING OBJECTS
        playerCharacter.transform.position = new Vector3(0, 1, 4.79f);

        microwaveAM.SetActive(false);
        bathroomSinkAM.SetActive(false);
        showerAM.SetActive(false);

        doTime = true;
        microwavePM.SetActive(true);
        bathroomSinkPM.SetActive(true);
        showerPM.SetActive(true);
        trashPM.SetActive(true);
        dishesPM.SetActive(true);
        dustPM.SetActive(true);

    }

    IEnumerator gameFinish()
    {
        bedTimeSkipAnim.SetActive(true);
        yield return new WaitForSeconds(6.0f);
        SceneManager.LoadScene("Demo");
    }



}
