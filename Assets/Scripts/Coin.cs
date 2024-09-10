using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    private float y = 0;
    private CanvasGameMng canvasGameMng;
    // Start is called before the first frame update
    void Start()
    {
        canvasGameMng = FindObjectOfType<CanvasGameMng>();
    }

    // Update is called once per frame
    void Update()
    {
        y += 300 * Time.deltaTime;
        transform.localRotation = Quaternion.Euler(0, y, 0);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.name == "Bola")
        {
            canvasGameMng.IncrementScore(50);
            Destroy(gameObject);
        }
    }
}