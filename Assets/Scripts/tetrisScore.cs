using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class tetrisScore : MonoBehaviour
{
    public static tetrisScore instance;
    public Text myScoreText;
    public Text gameOverScore;
    public Text highScoreText;
    public static int scoreValue = 0;
    public static int highScoreValue = 0;

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        highScoreValue = PlayerPrefs.GetInt("Highscore", highScoreValue);
        myScoreText.text = "Score: " + scoreValue;
        highScoreText.text = "Highscore\n" + highScoreValue;
    }


    private void Update()
    {
        myScoreText.text = "Score: " + scoreValue;
        gameOverScore.text = "Score\n" + scoreValue;
        if (highScoreValue < scoreValue)
        {
            PlayerPrefs.SetInt("Highscore", scoreValue);
        }

    }

}
