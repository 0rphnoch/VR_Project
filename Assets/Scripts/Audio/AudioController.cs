using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioController : MonoBehaviour
{
    public Slider _musicSlider, _sfxSlider;
    float musicValue, sfxValue;

    public void Start()
    {
        _musicSlider.value = PlayerPrefs.GetFloat("save1", musicValue);
        _sfxSlider.value = PlayerPrefs.GetFloat("save2", sfxValue);
    }

    public void MusicVolume()
    {
        AudioManager.Instance.MusicVolume(_musicSlider.value);
    }

    public void SFXVolume()
    {
        AudioManager.Instance.SFXVolume(_sfxSlider.value);
    }

    public void ChangeMusicSlider(float value)
    {
        musicValue = value;
        PlayerPrefs.SetFloat("save1", musicValue);
    }

    public void ChangeSfxSlider(float value)
    {
        sfxValue = value;
        PlayerPrefs.SetFloat("save2", sfxValue);
    }
}
