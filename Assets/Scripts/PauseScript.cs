using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//ポーズ画面関連のスクリプト
public class PauseScript : MonoBehaviour
{
    public GameObject PauseUI;
    
    public GameManager gameManager;

    void Update()
    {
        
    }
    public void PausePanel()
    {
        PauseUI.SetActive(!PauseUI.activeSelf);

        if (PauseUI.activeSelf)
        {
            Time.timeScale = 0f;
        }
        else
        {
            Time.timeScale = 1f;
        }
    }

    public void RetryButton()
    {
        gameManager.GameStart();
    }
    public void HomeButton()
    {
        gameManager.TitleScene();
        
    }
}
