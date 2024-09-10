using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasGameMng : MonoBehaviour
{
    public Text txtScore;
    private float score = 0;
    // Start is called before the first frame update
    void Start()
    {
        txtScore.text = "" + score;
    }

    public void IncrementScore(float points)
    {
        score += points;
        txtScore.text = "" + score;
    }
}
