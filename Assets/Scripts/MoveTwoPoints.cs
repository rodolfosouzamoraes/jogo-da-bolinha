using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class MoveTwoPoints : MonoBehaviour
{
    private Vector3 initialPosition;
    public Vector3 targetPosition;
    public float speed = 5;
    private bool isTargetPosition = false;
    // Start is called before the first frame update
    void Start()
    {
        initialPosition = transform.localPosition;
    }

    // Update is called once per frame
    void Update()
    {
        var step = speed * Time.deltaTime;
        if (isTargetPosition == false)
        {
            transform.localPosition = Vector3.MoveTowards(transform.localPosition, targetPosition, step);
            if (Vector3.Distance(transform.localPosition, targetPosition) < 0.001f)
            {
                isTargetPosition = true;
            }
        }
        else
        {
            transform.localPosition = Vector3.MoveTowards(transform.localPosition, initialPosition, step);
            if (Vector3.Distance(transform.localPosition, initialPosition) < 0.001f)
            {
                isTargetPosition = false;
            }
        }
    }
}
