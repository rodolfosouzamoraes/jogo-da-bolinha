using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GateWithKey : MonoBehaviour
{
    public Vector3 openPosition;
    public float movingSpeed;
    CanvasGameMng canvasGameMng;
    private bool isUnloked = false;
    private bool isOpenGate = false;
    // Start is called before the first frame update
    void Start()
    {
        canvasGameMng = FindObjectOfType<CanvasGameMng>();
    }

    private void Update()
    {
        if (isUnloked == true && isOpenGate == false) {
            transform.localPosition = Vector3.MoveTowards(transform.localPosition, openPosition, movingSpeed*Time.deltaTime);
            if (Vector3.Distance(transform.localPosition, openPosition) < 0.001f)
            {
                isOpenGate = true;
            }
        }
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Bola" && isUnloked == false)
        {
            if (canvasGameMng.keyItem != 0)
            {
                isUnloked = true;
                canvasGameMng.UseKeyItem();

            }
        }
    }
}
