using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ShowScore : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI highscoreText;
    void Update()
    {
        GameManager.Instance.highscore = PlayerPrefs.GetInt("highscore");
        scoreText.text = "Score : " + GameManager.Instance.score.ToString();
        highscoreText.text = "Highscore : " + GameManager.Instance.highscore.ToString();
    }
}
