using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SettingsMenu : MonoBehaviour {

    public AudioMixer audioMixer;
    public GameObject canvas;

    public void Activate() {
        canvas.SetActive(true);
    }

    public void Back() {
        canvas.SetActive(false);
    }

    public void SetVolume (float volume) {
        audioMixer.SetFloat("volume", volume);
    }

}
