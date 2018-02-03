using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetScores : MonoBehaviour {

    public Text highScore;
    public Text lastScore;


    private void Update()
    {
        highScore.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
        lastScore.text = PlayerPrefs.GetInt("LastScore", 0).ToString();
    }
}
