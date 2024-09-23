using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ActionButton : MonoBehaviour
{
    public Material materialOn;
    public Material materialOff;
    public MeshRenderer meshButton;
    public GameObject objectInGame;
    public string scriptName;
    private bool isButtonActived = false;
    // Start is called before the first frame update
    void Start()
    {
        meshButton.material = new Material(materialOff);
        (objectInGame.GetComponent(scriptName) as MonoBehaviour).enabled = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (isButtonActived == true) return;
        if (other.transform.name == "Bola")
        {
            meshButton.material = new Material(materialOn);
            (objectInGame.GetComponent(scriptName) as MonoBehaviour).enabled = true;
            isButtonActived = true;
        }
    }
}
