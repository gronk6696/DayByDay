using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;


public class buttonGame : MonoBehaviour
{
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
            shuffledButtons[i - 1].image.color = new Color32(30, 30, 67, 255);
        }
    }

    public void pressButton(Button button)
    {
        if(int.Parse(button.GetComponentInChildren<TMP_Text>().text)-1==counter)
        {
            counter++;
            button.interactable = false;
            button.image.color = new Color32(10,40,10,255);
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
                button.image.color = new Color32 (30,10,10,255);
                button.interactable = false;
            }
        }

        else if (win)
        {
            gamePanel.SetActive(false);
        }
        yield return new WaitForSeconds(2f);
        RestartTheGame();
    }
}
