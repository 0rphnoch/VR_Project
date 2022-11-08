using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    int score = 0;
    int highscore = 0;
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    void Start()
    {
        highscore = PlayerPrefs.GetInt("highscore", 0);
        Debug.Log(highscore);
    }

    public void HitHead()
    {
        score += 50;
        Debug.Log(score);
        if(highscore < score)
        {
            PlayerPrefs.SetInt("highscore", score);
        }
    }

    public void HitBody()
    {
        score += 20;
        Debug.Log(score);
        if (highscore < score)
        {
            PlayerPrefs.SetInt("highscore", score);
        }
    }

    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}
