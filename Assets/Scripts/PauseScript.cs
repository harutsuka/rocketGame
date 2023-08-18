using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using DG.Tweening;

//ポーズ画面関連のスクリプト
public class PauseScript : MonoBehaviour
{
    public GameObject PauseUI;

    public AudioSource audioSource;
    public AudioClip ButtonAudioClip;
    public SEPlayController SEPlayController;

    public GameManager gameManager;

    private bool isProcessing = false;

    public void OpenPausePanel()
    {
        if (!isProcessing)
        {
            isProcessing = true;
            SEPlayController.ButtonSE();

            DOVirtual.DelayedCall(ButtonAudioClip.length - 0.8f, () =>
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
              });
        }
    }

    public void RetryButton()
    {
        if (!isProcessing)
        {
            isProcessing = true;
            SEPlayController.ButtonSE();

            DOVirtual.DelayedCall(ButtonAudioClip.length - 0.8f, () =>
            {
                gameManager.GameStart();
                isProcessing = false;
            });
        }
    }
    public void HomeButton()
    {
        if (!isProcessing)
        {
            isProcessing = true;
            SEPlayController.ButtonSE();

            DOVirtual.DelayedCall(ButtonAudioClip.length - 0.8f, () =>
             {
                 gameManager.TitleScene();
                 isProcessing = false;
             });
        }
    }
}
