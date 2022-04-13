using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreSetter : MonoBehaviour
{
    int score;
    public Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
        score = PlayerPrefs.GetInt("score");
        scoreText.text = score.ToString();
    }
}
