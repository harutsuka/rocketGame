using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using DG.Tweening;

//リザルト画面関連のスクリプト
public class ResultUIScript : MonoBehaviour
{
    public GameManager gameManager;

    public SEPlayController SEPlayController;
    private bool isProcessing;
    public AudioClip ButtonAudioClip;

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
