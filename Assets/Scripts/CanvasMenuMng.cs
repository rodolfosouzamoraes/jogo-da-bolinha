using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CanvasMenuMng : MonoBehaviour
{
    public GameObject pnlMenu;
    public GameObject pnlLevels;
    public GameObject pnlSettings;
    public GameObject pnlInformations;
    public GameObject pnlTutorial;
    public GameObject pnlCredits;

    private Settings settings;

    public Slider sldVolumeVFX;
    public Slider sldVolumeMusic;

    private void Start()
    {
        settings = DBMng.GetSettings();
        AudioMng.Instance.SetVolume(settings.volumeMusic, settings.volumeVFX);
        AudioMng.Instance.PlayAudioMenu();
    }

    public void ShowPannelLevels()
    {
        pnlMenu.SetActive(false);
        pnlTutorial.SetActive(false);
        pnlLevels.SetActive(true);
    }

    public void ShowPannelMenu()
    {
        pnlMenu.SetActive(true);
        pnlLevels.SetActive(false);
        pnlSettings.SetActive(false);
        pnlInformations.SetActive(false);
        pnlCredits.SetActive(false);
        pnlTutorial.SetActive(false);
    }

    public void ShowPannelSettings()
    {
        pnlMenu.SetActive(false);
        sldVolumeVFX.value = settings.volumeVFX;
        sldVolumeMusic.value = settings.volumeMusic;
        pnlSettings.SetActive(true);
    }

    public void ShowPannelTutorial()
    {
        pnlLevels.SetActive(false);
        pnlTutorial.SetActive(true);
    }

    public void ShowPannelInformations()
    {
        pnlMenu.SetActive(false);
        pnlInformations.SetActive(true);
    }

    public void ShowPannelCredits()
    {
        pnlMenu.SetActive(false);
        pnlCredits.SetActive(true);
    }

    public void ChangeVolumeMusic()
    {
        DBMng.SaveSettings(sldVolumeMusic.value, settings.volumeVFX);
        settings = DBMng.GetSettings();
        AudioMng.Instance.SetVolume(settings.volumeMusic, settings.volumeVFX);
    }
    public void ChangeVolumeVFX()
    {
        DBMng.SaveSettings(settings.volumeMusic, sldVolumeVFX.value);
        settings = DBMng.GetSettings();
        AudioMng.Instance.SetVolume(settings.volumeMusic, settings.volumeVFX);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
