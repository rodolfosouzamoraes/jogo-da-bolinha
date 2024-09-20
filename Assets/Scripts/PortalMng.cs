using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalMng : MonoBehaviour
{

    public Portal portalIn;
    public Portal portalOut;
    public bool isUsePortalIn = false;
    public bool isUsePortalOut = false;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MoveToPortalOut(GameObject ball)
    {
        isUsePortalOut = true;
        ball.transform.position = portalOut.transform.position + new Vector3(0,1,0);
        
    }

    public void MoveToPortalIn(GameObject ball)
    {
        isUsePortalIn = true;
        ball.transform.position = portalIn.transform.position + new Vector3(0, 1, 0);
        
    }
}
