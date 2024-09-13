using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private CanvasGameMng canvasGameMng;
    private Rigidbody rigidbody;
    public float gravity = -5;
    // Start is called before the first frame update
    void Start()
    {
        canvasGameMng = FindObjectOfType<CanvasGameMng>();
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(canvasGameMng.isDisableInteraction == true)
        {
            GetComponent<Rigidbody>().isKinematic = true;
        }
        else
        {
            rigidbody.velocity = new Vector3(rigidbody.velocity.x,gravity,rigidbody.velocity.z);
        }
    }
}
