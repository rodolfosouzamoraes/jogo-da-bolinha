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

    private void Start()
    {
        AudioMng.Instance.PlayAudioMenu();
    }

    public void ShowPannelLevels()
    {
        pnlMenu.SetActive(false);
        pnlLevels.SetActive(true);
    }

    public void ShowPannelMenu()
    {
        pnlMenu.SetActive(true);
        pnlLevels.SetActive(false);
        pnlSettings.SetActive(false);
        pnlInformations.SetActive(false);
    }

    public void ShowPannelSettings()
    {
        pnlMenu.SetActive(false);
        pnlSettings.SetActive(true);
    }

    public void ShowPannelInformations()
    {
        pnlMenu.SetActive(false);
        pnlInformations.SetActive(true);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
