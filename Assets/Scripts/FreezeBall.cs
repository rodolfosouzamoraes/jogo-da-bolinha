using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreezeBall : MonoBehaviour
{
    public Transform transformRotateX;
    bool isFreeze = false;
    Ball ball;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "Bola" && isFreeze == false)
        {
            isFreeze = true;
            ball = other.GetComponent<Ball>();
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
