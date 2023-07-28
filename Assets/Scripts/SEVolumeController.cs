using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//効果音の音量を制御するスクリプト
public class SEVolumeController : MonoBehaviour
{
    public Slider slider;

    void Start()
    {
        slider.value = PlayerPrefs.GetFloat("SEVolume");
    }

    public void SoundSliderOnValueChange(float SEnewSliderValue)
    {
        PlayerPrefs.SetFloat("SEVolume", SEnewSliderValue);
        PlayerPrefs.Save();
    }

    public float GetVolume()
    {
        return PlayerPrefs.GetFloat("SEVolume");
    }
}
