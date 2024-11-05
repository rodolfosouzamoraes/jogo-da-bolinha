using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class FootballBoot : MonoBehaviour
{
    private CanvasGameMng canvasGameMng;
    public GameObject vfx;

    void Start()
    {
        canvasGameMng = FindObjectOfType<CanvasGameMng>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.name == "Bola")
        {
            canvasGameMng.IncrementFootballBoot();
            GameObject vfxInstantiate = Instantiate(vfx);
            vfxInstantiate.transform.position = transform.position;
            Destroy(gameObject);
        }
    }
}
