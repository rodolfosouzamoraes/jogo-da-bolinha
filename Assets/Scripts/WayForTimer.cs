using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class WayForTimer : MonoBehaviour
{
    public TextMeshPro txtTimer;
    public int timer;
    private int timerNow = 0;
    private float startTimer = 0;
    private bool isTiming = false;
    public bool IsTiming
    {
        get { return isTiming; }
    }
    // Start is called before the first frame update
    void Start()
    {
        ResetTiming();
    }

    // Update is called once per frame
    void Update()
    {
        if (isTiming == false) return;

        timerNow = timer - (int)(Time.time - startTimer);
        txtTimer.text = $"{timerNow}";
        if (timerNow < 0)
        {
            ResetTiming();
        }
    }

    public void StartTiming()
    {
        isTiming = true;
        startTimer = Time.time;
        txtTimer.text = $"{timer}";
        timerNow = 0;
    }

    public void ResetTiming() {
        isTiming = false;
        startTimer = Time.time;
        txtTimer.text = $"{timer}";
        timerNow = 0;
    }
}
