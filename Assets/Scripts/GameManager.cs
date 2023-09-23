using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using DG.Tweening;
using NCMB;

public class GameManager : MonoBehaviour
{
    public static int score = 0;
    public Text scoreText;

    public Text ResultText;
    public GameObject ResultUI;

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
        OpenResultPanel();
        CountDownTime = 0f;
        Time.timeScale = 0;
    }
    public void OpenResultPanel()
    {
        Time.timeScale = 0;
        ResultUI.SetActive(true);
        ResultText.text = score.ToString();
    }
    public void OpenRankingPanel()
    {
        naichilab.RankingLoader.Instance.SendScoreAndShowRanking(score);
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
