using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using DG.Tweening;

//タイトル画面関連のスクリプト
public class GameStartScript : MonoBehaviour
{
    public GameManager gameManager;
    public SEPlayController SEPlayController;

    public GameObject howToPlayPanel;
    public GameObject settingsUI;

    public GameObject startButton;
    public GameObject howToPlayButton;
    public GameObject bigImage;

    private bool isProcessing;
    public AudioClip ButtonAudioClip;

    public void StartButton()
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
    public void OpenSettingPanel()
    {
        if (!isProcessing)
        {
            isProcessing = true;
            SEPlayController.ButtonSE();

            DOVirtual.DelayedCall(ButtonAudioClip.length - 0.8f, () =>
             {
                 settingsUI.SetActive(true);
                 startButton.SetActive(false);
                 howToPlayButton.SetActive(false);
                 isProcessing = false;
             });
        }
    }
    public void CloseSettingsPanel()
    {
        if (!isProcessing)
        {
            isProcessing = true;
            SEPlayController.ButtonSE();

            DOVirtual.DelayedCall(ButtonAudioClip.length - 0.8f, () =>
             {
                 settingsUI.SetActive(false);
                 startButton.SetActive(true);
                 howToPlayButton.SetActive(true);
                 isProcessing = false;
             });
        }
    }
    public void OpenHowToPlayPanel()
    {
        if (!isProcessing)
        {
            isProcessing = true;
            SEPlayController.ButtonSE();

            DOVirtual.DelayedCall(ButtonAudioClip.length - 0.8f, () =>
            {
                howToPlayPanel.SetActive(true);
                isProcessing = false;
            });
        }
    }
    public void CloseHowToPlayPanel()
    {
        if (!isProcessing)
        {
            isProcessing = true;
            SEPlayController.ButtonSE();

            DOVirtual.DelayedCall(ButtonAudioClip.length - 0.8f, () =>
             {
                 howToPlayPanel.SetActive(false);
                 isProcessing = false;
             });
        }
    }
    public void OpenBigImage()
    {
        if (!isProcessing)
        {
            isProcessing = true;
            SEPlayController.ButtonSE();

            DOVirtual.DelayedCall(ButtonAudioClip.length - 0.8f, () =>
            {
                bigImage.SetActive(true);
                isProcessing = false;
            });
        }
    }
    public void CloseBigImage()
    {
        if (!isProcessing)
        {
            isProcessing = true;
            SEPlayController.ButtonSE();

            DOVirtual.DelayedCall(ButtonAudioClip.length - 0.8f, () =>
            {
                bigImage.SetActive(false);
                isProcessing = false;
            });
        }
    }
}