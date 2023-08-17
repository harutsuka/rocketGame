using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static int score = 0;
    public Text scoreText;

    public Text ResultText;
    public GameObject ResultUI;

    public int bestScore = 0;
    public Text bestScoreText;

    public float CountDownTime;
    public Text CountDownText;

    private void Awake()
    {
        QualitySettings.vSyncCount = 0;
        Application.targetFrameRate = 60;
    }
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        bestScore = PlayerPrefs.GetInt("SCORE", 0);
        CountDownTime = 20.0f;
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = score.ToString();

        //カウントダウン
        CountDownText.text = string.Format("{0:00.00}", CountDownTime);
        CountDownTime -= Time.deltaTime;
        if (CountDownTime <= 0)
        {
            GameEnd();
        }
    }

    public void GameStart()
    {
        SceneManager.LoadScene("Main");
        score = 0;
    }

    public void GameEnd()
    {
        //Time.timeScale = 0;
        OpenResultPanel();
    }
    public void OpenResultPanel()
    {
        ResultUI.SetActive(true);
        ResultText.text = score.ToString();

        if(bestScore < score)
        {
            bestScore = score;
            PlayerPrefs.SetInt("SCORE", bestScore);
            PlayerPrefs.Save();
        }
        bestScoreText.text = "BEST SCORE : " + bestScore.ToString();
    }
    public void AddScore()
    {
        score += 1;
    }
    public void TitleScene()
    {
        SceneManager.LoadScene("Title");
    }
}
