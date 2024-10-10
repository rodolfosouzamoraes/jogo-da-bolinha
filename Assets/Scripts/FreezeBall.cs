using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreezeBall : MonoBehaviour
{
    public Transform transformRotateX;
    private bool isFreeze = false;
    private Ball ball;
    public GameObject vfx;
    // Start is called before the first frame update
    void Start()
    {
        ball = FindObjectOfType<Ball>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "Bola" && isFreeze == false)
        {
            isFreeze = true;
            GameObject vfxInstantiate = Instantiate(vfx);
            vfxInstantiate.transform.position = ball.transform.position;
            ball.DisableGravity();
            ball.transform.SetParent(transformRotateX);
            Invoke("FreeFreeze", 3);
        }
    }

    private void FreeFreeze()
    {
        if (isFreeze == true) { 
            ball.transform.SetParent(null);
            ball.EnableGravity();
            isFreeze = false;
        }
    }
}
