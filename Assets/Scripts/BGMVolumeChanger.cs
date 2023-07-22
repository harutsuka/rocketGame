using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BGMVolumeChanger : MonoBehaviour
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

    public void SoundSliderOnValueChange(float newSliderValue)
    {
        audioSource.volume = newSliderValue;

        PlayerPrefs.SetFloat("Volume", newSliderValue);
        PlayerPrefs.Save();
    }
}
