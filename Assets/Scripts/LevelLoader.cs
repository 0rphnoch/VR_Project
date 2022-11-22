using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    public void PlayGame()
    {
        GameManager.Instance.score = 0;
        LoadLevel("Demo 1");
        //PlayerPrefs.SetInt("highscore", score);
    }
    public void LoadLevel(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void ExitGame()
    {
        Application.Quit();
    }

}
