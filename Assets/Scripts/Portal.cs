using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{
    public int id;
    private PortalMng portalMng;
    // Start is called before the first frame update
    void Start()
    {
        portalMng = GetComponentInParent<PortalMng>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.transform.name == "Bola")
        {
            if(id == 0 && portalMng.isUsePortalIn == false)
            {
                portalMng.MoveToPortalOut(other.gameObject);
            }
            else if(id == 1 && portalMng.isUsePortalOut == false)
            {
                portalMng.MoveToPortalIn(other.gameObject);
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.transform.name == "Bola")
        {
            if(id == 0)
            {
                portalMng.isUsePortalIn = false;
            }
            else
            {
                portalMng.isUsePortalOut = false;
            }
        }
    }
}
