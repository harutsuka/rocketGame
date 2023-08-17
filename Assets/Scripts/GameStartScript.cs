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

    public GameObject settingsUI;

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
                 isProcessing = false;
             });
        }
    }
}
