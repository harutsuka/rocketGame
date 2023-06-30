using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public static int score = 0;
    public Text scoreText;
    public Text gameOverText;
    public RocketController rocket;
    public GameObject button;

    public static float CountDownTime;
    public Text CountDownText;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        CountDownTime = 30.0f;
        button.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = score.ToString();
        
        //タイマー
        CountDownText.text = string.Format("{0:00.00}", CountDownTime);
        CountDownTime -= Time.deltaTime;
        if(CountDownTime <= 0)
        {
            Time.timeScale = 0;
        }
    }
    public void GameOver()
    {
        gameOverText.text = "GameOver";
        button.SetActive(true);
        //Time.timeScale = 0;
    }
    public void AddScore()
    {
        score += 1;
    }
}
