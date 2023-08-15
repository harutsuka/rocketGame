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

    private bool isProcessing;
    public AudioClip ButtonAudioClip;

    public void ReadyToStart()
    {
        if (!isProcessing)
        {
            isProcessing = true;
            SEPlayController.ButtonSE();

            DOVirtual.DelayedCall(ButtonAudioClip.length - 1f, () =>
            {
                gameManager.GameStart();
                isProcessing = false;
            });
        }
    }    
}
