using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationX : MonoBehaviour
{
    public float speed;
    private float x = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            x += speed * Time.deltaTime * -1;
            transform.localRotation = Quaternion.Euler(x, 0, 0);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            x += speed * Time.deltaTime;
            transform.localRotation = Quaternion.Euler(x, 0, 0);
        }
    }
}
