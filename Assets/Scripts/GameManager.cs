using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public int score = 0;
    public int highscore = 0;
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
        
        if (highscore < score)
        {
            PlayerPrefs.SetInt("highscore", score);
        }
    }

    public void HitBody()
    {
        score += 20;
        
        if (highscore < score)
        {
            PlayerPrefs.SetInt("highscore", score);
        }
    }
}
