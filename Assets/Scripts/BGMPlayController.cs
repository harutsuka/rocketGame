using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//BGMの音量を制御するスクリプト
public class BGMPlayController : MonoBehaviour
{
    private AudioSource audioSource;
    public Slider slider;
    void Start()
    {
        audioSource = gameObject.GetComponent<AudioSource>();

        audioSource.volume = PlayerPrefs.GetFloat("BGMVolume",0.5f);
        slider.value = PlayerPrefs.GetFloat("BGMVolume",0.5f);
    }

    public void SoundSliderOnValueChange(float BGMnewSliderValue)
    {
        audioSource.volume = BGMnewSliderValue;

        PlayerPrefs.SetFloat("BGMVolume", BGMnewSliderValue);
        PlayerPrefs.Save();
    }
}
