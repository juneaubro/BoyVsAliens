using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SetVolume : MonoBehaviour
{

    public AudioMixer mixer;

    public void SetLevel(float sliderValue)
    {
        sliderValue = PlayerPrefs.GetFloat("Volume", 1f);

        mixer.SetFloat("MusicExpose", Mathf.Log10(sliderValue) * 20);
    }
}