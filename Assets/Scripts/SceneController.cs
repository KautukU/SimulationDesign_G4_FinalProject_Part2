using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneController : MonoBehaviour
{
    public Scene currentScene;
    void Start()
    {
        currentScene = SceneManager.GetActiveScene();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void LoadVictory()
    {
        SceneManager.LoadScene("WinScene");
    }
    public void LoadLose()
    {
        SceneManager.LoadScene("LostScene");
    }
    public void LoadGame()
    {
        Debug.Log("gvdkfjg");
        SceneManager.LoadScene("RollerBall");
    }
}
