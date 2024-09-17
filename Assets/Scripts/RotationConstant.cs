using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationConstant : MonoBehaviour
{
    public bool[] rotationEnable;
    public float speed;
    private float x = 0, y = 0, z = 0;

    // Update is called once per frame
    void Update()
    {
        x += rotationEnable[0] == true ? speed * Time.deltaTime : x = 0;
        y += rotationEnable[1] == true ? speed * Time.deltaTime : y = 0;
        z += rotationEnable[2] == true ? speed * Time.deltaTime : z = 0;

        transform.localRotation = Quaternion.Euler(x, y, z);
    }
}
