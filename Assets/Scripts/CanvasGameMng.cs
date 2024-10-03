using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
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

    // Start is called before the first frame update
    void Start()
    {
        txtScore.text = "" + score;
        ball = FindObjectOfType<Ball>().gameObject;
        startTime = Time.time;

        scoreTotalLevel = (FindObjectsOfType<Coin>().Length * coinPoints) + targetLevelPoints;
        starOn1.SetActive(false);
        starOn2.SetActive(false);
        starOn3.SetActive(false);
    }

    private void Update()
    {
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
        isDisableInteraction = true;
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

    public void EndLevel()
    {
        isDisableInteraction = true;
        txtResult1.text = $"{timerNow} x {score}";
        percentualScore = (score / scoreTotalLevel)*100;
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

    private void CalculateStars()
    {
        if(percentualScore < 50 && percentualScore >= 20)
        {
            starOn1.SetActive(true);
        }
        else if(percentualScore < 90 && percentualScore >= 50)
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
}
