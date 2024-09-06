using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTab : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(speed*Time.deltaTime*-1,0,0,0);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(speed * Time.deltaTime, 0, 0, 0);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Rotate(0, 0, speed * Time.deltaTime, 0);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Rotate(0, 0, speed * Time.deltaTime*-1, 0);
        }
    }
}
