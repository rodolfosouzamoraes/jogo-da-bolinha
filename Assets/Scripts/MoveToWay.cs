using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToWay : MonoBehaviour
{
    public Vector3[] wayPoints;
    public float speed;
    private int wayId;

    public float waitTime;
    private bool nextWay = false;
    private float nextTimer;
    // Start is called before the first frame update
    void Start()
    {
        transform.localPosition = wayPoints[0];
        wayId = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if(nextWay == true)
        {
            //lógica para ir para o próximo caminho
            if (Time.time > nextTimer) 
            {
                wayId++;
                if (wayId == wayPoints.Length) 
                {
                    wayId = 0;
                }
                nextWay = false;
            }
        }
        else
        {
            float movingSpeed = speed * Time.deltaTime;
            transform.localPosition = Vector3.MoveTowards(transform.localPosition, wayPoints[wayId],movingSpeed);
            if (Vector3.Distance(transform.localPosition, wayPoints[wayId]) < 0.001f)
            {
                nextTimer = Time.time + waitTime;
                nextWay = true;
            }
        }
    }
}
