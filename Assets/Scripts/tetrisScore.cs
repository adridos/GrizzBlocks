using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class tetrisScore : MonoBehaviour
{
    public Text myScoreText;
    public static int scoreValue = 0;
    void Start()
    {
        myScoreText.text = "Score: " + scoreValue;
    }


    private void Update(){
        myScoreText.text = "Score: " + scoreValue;

    }

}
