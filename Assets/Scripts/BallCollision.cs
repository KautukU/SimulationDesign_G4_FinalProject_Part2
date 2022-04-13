using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallCollision : MonoBehaviour
{
    public int points;
    public Text pointsText;
    private float nextActionTime = 0.0f;
    public float period = 0.5f;
    public void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.name == "PlayerBall")
        {

            if (Time.time > nextActionTime)
            {
                nextActionTime += period;
                points += 10;
                pointsText.text = points.ToString();
                PlayerPrefs.SetInt("score", points);
            }
           
        }
    }
}
