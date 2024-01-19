using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;


public class buttonGame : MonoBehaviour
{
    public GameObject physicalObject;
    public GameObject gamePanel;
    public List <Button> buttons;
    public List<Button> shuffledButtons;
    int counter = 0;

    public void Start()
    {
        gamePanel.SetActive(true);

        RestartTheGame();
    }

    public void RestartTheGame()
    {
        counter = 0;
        
        shuffledButtons=buttons.OrderBy(a=>Random.Range(0, 100)).ToList();
        for (int i = 1; i<11;i++)
        {
            shuffledButtons[i - 1].GetComponentInChildren<TMP_Text>().text = i.ToString();
            shuffledButtons[i-1].interactable = true;
            shuffledButtons[i - 1].image.color = new Color32(51, 82, 78, 255);
        }
    }

    public void pressButton(Button button)
    {
        if(int.Parse(button.GetComponentInChildren<TMP_Text>().text)-1==counter)
        {
            counter++;
            button.interactable = false;
            button.image.color = new Color32(112, 66, 101, 255);
            if (counter == 10)
            {
                StartCoroutine(presentResult(true));
            }

        }
        else
        {
            StartCoroutine (presentResult(false));
        }
    }

    public IEnumerator presentResult(bool win)
    {
        if (!win)
        {
            foreach(var button in shuffledButtons)
            {
                button.image.color = new Color32 (107, 41, 41,255);
                button.interactable = false;
            }
        }

        else if (win)
        {
            physicalObject.SetActive(false);
            gamePanel.SetActive(false);
        }
        yield return new WaitForSeconds(2f);
        RestartTheGame();
    }
}
