using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootballBoot : MonoBehaviour
{
    private CanvasGameMng canvasGameMng;
    public GameObject vfx;
    // Start is called before the first frame update
    void Start()
    {
        canvasGameMng = FindObjectOfType<CanvasGameMng>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "Bola")
        {
            canvasGameMng.IncrementFootballBoot();
            GameObject vfxInstantiate = Instantiate(vfx);
            vfxInstantiate.transform.position = transform.position;
            AudioMng.Instance.PlayAudioBoot();
            Destroy(gameObject);
        }
    }
}
