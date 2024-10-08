using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ItemLevel : MonoBehaviour
{
    public int idLevel;

    public GameObject pnlLevelOn;
    public GameObject pnlLevelOff;

    public Text txtLevelOn;
    public Text txtLevelOff;

    public GameObject starOn1;
    public GameObject starOn2;
    public GameObject starOn3;

    private float percentualScore;
    private int enableLevel;

    // Start is called before the first frame update
    void Start()
    {
        starOn1.SetActive(false);
        starOn2.SetActive(false);
        starOn3.SetActive(false);

        percentualScore = DBMng.GetScoreLevel(idLevel);
        CalculateStars();

        txtLevelOff.text = idLevel.ToString();
        txtLevelOn.text = idLevel.ToString();

        enableLevel = DBMng.GetEnableLevel(idLevel);

        if(idLevel != 1)
        {
            if(enableLevel == 1)
            {
                pnlLevelOn.SetActive(true);
            }
            else
            {
                pnlLevelOn.SetActive(false);
                pnlLevelOff.SetActive(true);
            }
        }

    }

    public void CalculateStars()
    {
        if (percentualScore >= 20 && percentualScore < 50)
        {
            starOn1.SetActive(true);
        }
        else if (percentualScore >= 50 && percentualScore < 90)
        {
            starOn1.SetActive(true);
            starOn2.SetActive(true);
        }
        else if (percentualScore >= 90)
        {
            starOn1.SetActive(true);
            starOn2.SetActive(true);
            starOn3.SetActive(true);
        }
    }

    public void LoadLevel()
    {
        if(idLevel == 1 || enableLevel == 1)
        {
            SceneManager.LoadScene(idLevel);
        }        
    }
}
