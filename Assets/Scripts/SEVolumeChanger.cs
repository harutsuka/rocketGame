using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//効果音の音量を制御するスクリプト
public class SEVolumeChanger : MonoBehaviour
{
    private AudioSource audioSource;
    public Slider slider;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = gameObject.GetComponent<AudioSource>();

        audioSource.volume = PlayerPrefs.GetFloat("Volume");
        slider.value = PlayerPrefs.GetFloat("Volume");
    }

    public void SoundSliderOnValueChange(float SEnewSliderValue)
    {
        audioSource.volume = SEnewSliderValue;

        PlayerPrefs.SetFloat("Volume", SEnewSliderValue);
        PlayerPrefs.Save();

        Debug.Log("SE: " + SEnewSliderValue);
    }
}
