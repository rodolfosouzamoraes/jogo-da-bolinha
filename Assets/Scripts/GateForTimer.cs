using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateForTimer : MonoBehaviour
{
    public Vector3 openPosition;
    private Vector3 initialPosition;
    public float movingSpeed;
    private WayForTimer wayForTimer;
    // Start is called before the first frame update
    void Start()
    {
        wayForTimer = GetComponentInParent<WayForTimer>();
        initialPosition = transform.localPosition;
    }

    // Update is called once per frame
    void Update()
    {
        if (wayForTimer.IsTiming == true) {
            transform.localPosition = Vector3.MoveTowards(transform.localPosition, openPosition, movingSpeed * Time.deltaTime);
        }
        else
        {
            transform.localPosition = Vector3.MoveTowards(transform.localPosition, initialPosition, movingSpeed * Time.deltaTime);
        }
    }
}
