using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

//効果音を再生するスクリプト
public class SEPlayController : MonoBehaviour
{
    public SEVolumeController volumeController;
    public AudioSource audioSource;
    public AudioClip ButtonAudioClip;
    public AudioClip BeamAudioClip;

    public void BeamSE()
    {
        audioSource.volume = volumeController.GetVolume();
        audioSource.PlayOneShot(BeamAudioClip);
    }
    public void ButtonSE()
    {
        audioSource.PlayOneShot(ButtonAudioClip);
    }
    
}
