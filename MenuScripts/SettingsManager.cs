using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingsManager : MonoBehaviour {

    public Toggle fullscreenToggle;
    public Dropdown resolutionDropdown;
    public Slider musicVolumeSlider;

    public AudioSource musicSource;
    public Resolution[] resolution;
    public GameSettings gameSettings;


    // Use this for initialization
    void OnEnable() {
        gameSettings = new GameSettings();

        fullscreenToggle.onValueChanged.AddListener(delegate { OnFullscreenToggle(); });
        resolutionDropdown.onValueChanged.AddListener(delegate { OnResolutionChange(); });
        musicVolumeSlider.onValueChanged.AddListener(delegate { OnMusicVolumeChange(); });


        resolution = Screen.resolutions;
        foreach (Resolution resolution in resolution)
        {
            resolutionDropdown.options.Add(new Dropdown.OptionData(resolution.ToString()));
        }

    }

    public void OnFullscreenToggle()
    {
        gameSettings.fullscreen = Screen.fullScreen = fullscreenToggle.isOn;
    }

    public void OnResolutionChange()
    {
        Screen.SetResolution(resolution[resolutionDropdown.value].width, resolution[resolutionDropdown.value].height, Screen.fullScreen);
    }

    public void OnMusicVolumeChange()
    {
        musicSource.volume = gameSettings.musicVolume = musicVolumeSlider.value;
    }

    public void SaveSettings()
    {

    }

    public void LoadSettings()
    {

    }
}
