using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SawBlade : MonoBehaviour
{
    private float y = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        y += 300 * Time.deltaTime;
        transform.localRotation = Quaternion.Euler(0, y, 0);
    }
}
