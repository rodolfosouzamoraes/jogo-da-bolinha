using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationZ : MonoBehaviour
{
    public float speed;
    private float z = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            z += speed * Time.deltaTime;
            transform.localRotation = Quaternion.Euler(0,0,z);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            z += speed * Time.deltaTime *-1;
            transform.localRotation = Quaternion.Euler(0, 0, z);
        }
    }
}
