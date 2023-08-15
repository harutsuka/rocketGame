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

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void RetryButton()
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
    public void HomeButton()
    {
        if (!isProcessing)
        {
            isProcessing = true;
            SEPlayController.ButtonSE();

            DOVirtual.DelayedCall(ButtonAudioClip.length - 1f, () =>
            {
                gameManager.TitleScene();
                isProcessing = false;
            });
        }
    }
}
