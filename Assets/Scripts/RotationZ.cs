using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationZ : MonoBehaviour
{
    public float speed;
    private float z = 0;
    private CanvasGameMng canvasGameMng;
    // Start is called before the first frame update
    void Start()
    {
        canvasGameMng = FindObjectOfType<CanvasGameMng>();
    }

    // Update is called once per frame
    void Update()
    {
        if (canvasGameMng.isDisableInteraction == true) return;

        if (Input.GetKey(KeyCode.UpArrow))
        {
            z += speed * Time.deltaTime;
            z = Mathf.Clamp(z, -20, 20);
            transform.localRotation = Quaternion.Euler(0,0,z);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            z += speed * Time.deltaTime *-1;
            z = Mathf.Clamp(z, -20, 20);
            transform.localRotation = Quaternion.Euler(0, 0, z);
        }
    }
}
