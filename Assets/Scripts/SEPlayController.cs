using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//効果音を再生するスクリプト
public class SEPlayController : MonoBehaviour
{
    public SEVolumeController volumeController;
    public AudioSource audioSource;
    public AudioClip audioClip;

    public void PlaySE()
    {
        audioSource.volume = volumeController.GetVolume();
        audioSource.PlayOneShot(audioClip);
    }
}
