using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationConstant : MonoBehaviour
{
    public bool[] rotationEnable;
    public float speed = 0;
    private float x, y, z = 0;

    public void Update()
    {
        x += rotationEnable[0] == true ? speed * Time.deltaTime : 0;
        y += rotationEnable[1] == true ? speed * Time.deltaTime : 0;
        z += rotationEnable[2] == true ? speed * Time.deltaTime : 0;

        transform.localRotation = Quaternion.Euler(x,y,z);
    }
}
