using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class Timer : MonoBehaviour
{
    public float timeValue = 90;
    public TextMeshProUGUI timerText;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI highScoreText;
    public GameObject panelEndGame;
    public GameObject leftHand;
    public GameObject rightHand;
    public GameObject ninja;

    void Update()
    {
        if (timeValue > 0)
        {
            timeValue -= Time.deltaTime;
        }
        else if(timeValue <= 0)
        {
            panelEndGame.SetActive(true);
            TimeOut();
        }
        DisplayTime(timeValue);
        //TimeOut();
    }

    void DisplayTime(float timeToDisplay)
    {
        if (timeToDisplay < 0)
        {
            timeToDisplay = 0;
        }
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
    void TimeOut()
    {
        scoreText.text = "Score : " + GameManager.Instance.score.ToString();
        highScoreText.text = "Highscore : " + GameManager.Instance.highscore.ToString();
        leftHand.SetActive(true);
        rightHand.SetActive(true);
        ninja.SetActive(false);
    }
}
