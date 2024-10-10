using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemKey : MonoBehaviour
{
    CanvasGameMng canvasGameMng;
    public GameObject vfx;
    // Start is called before the first frame update
    void Start()
    {
        canvasGameMng = FindObjectOfType<CanvasGameMng>();
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.name == "Bola")
        {
            canvasGameMng.IncrementKey();
            canvasGameMng.IncrementScore(100);
            GameObject vfxInstantiate = Instantiate(vfx);
            vfxInstantiate.transform.position = transform.position;
            Destroy(gameObject);
        }
    }
}
