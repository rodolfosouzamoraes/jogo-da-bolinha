using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerButton : MonoBehaviour
{
    public Material materialOn;
    public Material materialOff;
    public MeshRenderer meshButton;
    private WayForTimer wayForTimer;
    // Start is called before the first frame update
    void Start()
    {
        wayForTimer = GetComponentInParent<WayForTimer>();
        meshButton.material = new Material(materialOff);
    }

    // Update is called once per frame
    void Update()
    {
        if (wayForTimer.IsTiming == true) 
        {
            meshButton.material = new Material(materialOn);
        }
        else
        {
            meshButton.material = new Material(materialOff);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (wayForTimer.IsTiming == true) return;
        if(other.transform.name == "Bola")
        {
            AudioMng.Instance.PlayAudioButton();
            wayForTimer.StartTiming();
        }
    }
}
