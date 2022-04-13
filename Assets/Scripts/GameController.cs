using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public float timeRemaining = 30;
    public Text timeText;
    public GameObject ball;
    public Text lives;
    public float livesRemaining = 3;
    public PlayerController playerController;

    // Start is called before the first frame update
    void Start()
    {
        playerController = GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (ball.transform.position.y <= -25)
        {
            if(livesRemaining > 0)
            {
                livesRemaining--;
                lives.text = livesRemaining + "/3";
                ball.transform.position = new Vector3(-11, 5, 0);
            }
            else
            {
                SceneManager.LoadScene("LostScene");
            }

        }
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
            DisplayTime(timeRemaining);
        }
        else
        {
            Debug.Log("Time has run out!");
            timeRemaining = 0;
            SceneManager.LoadScene("WinScene");
        }
    }
    void DisplayTime(float timeToDisplay)
    {
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        float milliSeconds = (timeToDisplay % 1) * 1000;
        timeText.text = string.Format("{0:00}:{1:00}:{2:000}", minutes, seconds, milliSeconds);
    }
}
