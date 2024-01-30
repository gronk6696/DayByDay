using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneChanger : MonoBehaviour
{
    public void changeScene(string sceneName)
    {
        Debug.Log("Attempt to change");
        SceneManager.LoadScene(sceneName);
    }
}
