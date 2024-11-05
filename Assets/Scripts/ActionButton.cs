using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
        var obj = objectInGame.GetComponent(scriptName) as MonoBehaviour;
        obj.enabled = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (isButtonActived == true) return;

        if(other.transform.name == "Bola")
        {
            AudioMng.Instance.PlayAudioButton();
            meshButton.material = new Material(materialOn);
            var obj = objectInGame.GetComponent(scriptName) as MonoBehaviour;
            obj.enabled = true;
        }
    }
}
