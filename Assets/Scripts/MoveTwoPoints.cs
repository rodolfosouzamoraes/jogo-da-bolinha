using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTwoPoints : MonoBehaviour
{
    public Vector3 targetPosition;
    public float speed = 5;
    private Vector3 initialPosition;
    private bool isTargetPosition = false;
    // Start is called before the first frame update
    void Start()
    {
        initialPosition = transform.localPosition;
    }

    // Update is called once per frame
    void Update()
    {
        float movingSpeed = speed * Time.deltaTime;
        if(isTargetPosition == false)
        {
            transform.localPosition = Vector3.MoveTowards(transform.localPosition,targetPosition,movingSpeed);
            if (Vector3.Distance(transform.localPosition, targetPosition) < 0.001f)
            {
                isTargetPosition = true;
            }
        }
        else
        {
            transform.localPosition = Vector3.MoveTowards(transform.localPosition, initialPosition, movingSpeed);
            if (Vector3.Distance(transform.localPosition, initialPosition) < 0.001f)
            {
                isTargetPosition = false;
            }
        }
    }
}
