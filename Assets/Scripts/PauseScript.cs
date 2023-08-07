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
    public AudioClip audioClip;

    public GameManager gameManager;

    private bool isProcessing = false;

    public void PausePanel()
    {
        audioSource.PlayOneShot(audioClip);
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
        if (!isProcessing)
        {
            isProcessing = true;
            
            SEPlay();
            DOVirtual.DelayedCall(audioClip.length, () =>
            {
                gameManager.GameStart();
                isProcessing = false;
            });
             
        }
    }
    public void HomeButton()
    {
        gameManager.TitleScene();
        audioSource.PlayOneShot(audioClip);
    }
    public void SEPlay()
    {
        audioSource.PlayOneShot(audioClip);
    }
}
