using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Trap : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.transform.name == "Bola")
        {
            var canvasGame = FindObjectOfType<CanvasGameMng>();
            canvasGame.GameOver();         
        }
    }
}
