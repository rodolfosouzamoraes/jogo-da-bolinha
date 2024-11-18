using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CanvasMenuMng : MonoBehaviour
{
    public GameObject pnlMenu;
    public GameObject pnlLevels;
    public GameObject pnlSettings;
    public GameObject pnlInformations;
    public GameObject pnlTutorial;
    public GameObject pnlCredits;

    private void Start()
    {
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

    public void ExitGame()
    {
        Application.Quit();
    }
}
