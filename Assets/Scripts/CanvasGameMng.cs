using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CanvasGameMng : MonoBehaviour
{
    public Text txtScore;
    private float score = 0;
    private float scoreFinal = 0;

    public bool isDisableInteraction = false;
    private GameObject ball;

    public Text txtTimer;
    public int timerGame = 60;
    private int timerNow = 0;
    private float startTime;

    public GameObject pnlEndLevel;
    public Text txtResult1;
    public Text txtResult2;

    public int keyItem = 0;

    public int coinPoints;
    public int targetLevelPoints;

    private int scoreTotalLevel = 0;
    private float percentualScore = 0;

    public GameObject starOn1;
    public GameObject starOn2;
    public GameObject starOn3;

    private int idLevel;
    public GameObject vfxExplosionBall;

    private int collectFootbalBoot;
    public GameObject[] imgsFootballBoot;

    public TextMeshProUGUI txtLevel;
    public Image imgMedalBoot;
    public Sprite[] sptMedalBoot;

    // Start is called before the first frame update
    void Start()
    {
        txtScore.text = "" + score;
        ball = FindObjectOfType<Ball>().gameObject;
        startTime = Time.time;

        scoreTotalLevel = FindObjectsOfType<Coin>().Length * coinPoints + targetLevelPoints;
    
        starOn1.SetActive(false);
        starOn2.SetActive(false);
        starOn3.SetActive(false);

        idLevel = SceneManager.GetActiveScene().buildIndex;

        AudioMng.Instance.PlayAudioApito();

        collectFootbalBoot = 0;
        txtLevel.text = $"Lv. {idLevel}";

        AudioMng.Instance.PlayAudioGame();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) GoToMenu();
        if (isDisableInteraction == true) return;

        timerNow = timerGame - (int)(Time.time - startTime);
        txtTimer.text = $"{timerNow}";
        if (timerNow < 1)
        {
            GameOver();
        }
    }

    public void IncrementScore(float points)
    {
        score += points;
        txtScore.text = "" + score;
    }

    public void GameOver()
    {
        AudioMng.Instance.PlayAudioExplosion();
        isDisableInteraction = true;
        GameObject vfxInstantiate = Instantiate(vfxExplosionBall);
        vfxInstantiate.transform.position = ball.transform.position;
        Destroy(ball);
        Invoke("ReloadScene", 2.5f);
    }

    public void ReloadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }

    public void GoToMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void EndLevel()
    {
        isDisableInteraction = true;
        txtResult1.text = $"{timerNow} x {score}";
        percentualScore = (score / scoreTotalLevel) * 100;
        CalculateMedalBoot();
        DBMng.SaveLevel(idLevel,percentualScore,collectFootbalBoot);
        CalculateStars();
        scoreFinal = timerNow * score;
        txtResult2.text = $"{scoreFinal}pts";
        pnlEndLevel.SetActive(true);
    }

    public void IncrementKey()
    {
        keyItem++;
    }

    public void UseKeyItem()
    {
        keyItem--;
    }

    public void CalculateStars()
    {
        if(percentualScore >= 20 && percentualScore < 50)
        {
            starOn1.SetActive(true);
        }
        else if (percentualScore >= 50 && percentualScore < 90)
        {
            starOn1.SetActive(true);
            starOn2.SetActive(true);
        }
        else if(percentualScore >= 90)
        {
            starOn1.SetActive(true);
            starOn2.SetActive(true);
            starOn3.SetActive(true);
        }
    }

    public void CalculateMedalBoot()
    {
        imgMedalBoot.sprite = sptMedalBoot[collectFootbalBoot];
    }

    public void IncrementFootballBoot()
    {
        collectFootbalBoot++;
        imgsFootballBoot[collectFootbalBoot-1].SetActive(true);
    }
}
