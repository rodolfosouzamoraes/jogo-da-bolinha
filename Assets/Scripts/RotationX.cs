using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationX : MonoBehaviour
{
    public float speed;
    private float x = 0;
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

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            x += speed * Time.deltaTime * -1;
            x = Mathf.Clamp(x, -20, 20);
            transform.localRotation = Quaternion.Euler(x, 0, 0);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            x += speed * Time.deltaTime;
            x = Mathf.Clamp(x, -20, 20);
            transform.localRotation = Quaternion.Euler(x, 0, 0);
        }
    }
}
