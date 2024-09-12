using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private CanvasGameMng canvasGameMng;
    // Start is called before the first frame update
    void Start()
    {
        canvasGameMng = FindObjectOfType<CanvasGameMng>();
    }

    // Update is called once per frame
    void Update()
    {
        if(canvasGameMng.isDisableInteraction == true)
        {
            GetComponent<Rigidbody>().isKinematic = true;
        }
    }
}
