using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateWithKey : MonoBehaviour
{
    public Vector3 openPosition;
    public float movingSpeed;
    private CanvasGameMng canvasGameMng;
    private bool isUnlocked = false;
    private bool isOpenGate = false;
    public GameObject keyHole;
    // Start is called before the first frame update
    void Start()
    {
        canvasGameMng = FindObjectOfType<CanvasGameMng>();
    }

    // Update is called once per frame
    void Update()
    {
        if(isUnlocked == true && isOpenGate == false)
        {
            transform.localPosition = Vector3.MoveTowards(transform.localPosition, openPosition, movingSpeed * Time.deltaTime);
            if(Vector3.Distance(transform.localPosition, openPosition) < 0.001f)
            {
                isOpenGate = true;
            }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.transform.name == "Bola" && isUnlocked == false)
        {
            if(canvasGameMng.keyItem != 0)
            {
                canvasGameMng.UseKeyItem();
                keyHole.SetActive(false);
                isUnlocked = true;
            }
        }
    }
}
