using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionsMenu : MonoBehaviour
{

    public Slider volumeSlider;

    public void SetVolume()
    {
        PlayerPrefs.SetFloat("Volume", volumeSlider.value);
        Debug.Log(PlayerPrefs.GetFloat("Volume"));
    }
}
