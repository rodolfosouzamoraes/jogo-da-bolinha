using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetLevel : MonoBehaviour
{
    private CanvasGameMng canvasGameMng;
    // Start is called before the first frame update
    void Start()
    {
        canvasGameMng = FindObjectOfType<CanvasGameMng>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.transform.name == "Bola")
        {
            canvasGameMng.IncrementScore(canvasGameMng.targetLevelPoints);
            canvasGameMng.EndLevel();
            Destroy(gameObject);
        }
    }
}
