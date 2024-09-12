using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Trap : MonoBehaviour
{
    private CanvasGameMng canvasGameMng;

    private void Start()
    {
        canvasGameMng = FindObjectOfType<CanvasGameMng>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.transform.name == "Bola")
        {
            canvasGameMng.GameOver();
        }
    }
}
