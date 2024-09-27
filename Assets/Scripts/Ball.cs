using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public Material materialOn;
    public Material materialOff;
    private MeshRenderer meshBall;
    private CanvasGameMng canvasGameMng;
    private Rigidbody rigidbody;
    public float gravity = -5;
    bool isUseGravity = true;
    // Start is called before the first frame update
    void Start()
    {
        canvasGameMng = FindObjectOfType<CanvasGameMng>();
        rigidbody = GetComponent<Rigidbody>();
        meshBall = GetComponent<MeshRenderer>();
        meshBall.material = new Material(materialOn);
    }

    // Update is called once per frame
    void Update()
    {
        if (rigidbody == null) return;
        if(canvasGameMng.isDisableInteraction == true)
        {
            rigidbody.isKinematic = true;
        }
        else
        {
            rigidbody.velocity = new Vector3(rigidbody.velocity.x, gravity, rigidbody.velocity.z);

        }
    }

    public void DisableGravity()
    {
        meshBall.material = new Material(materialOff);
        Destroy(rigidbody);
    }

    public void EnableGravity()
    {
        meshBall.material = new Material(materialOn);
        rigidbody = gameObject.AddComponent<Rigidbody>();
        rigidbody.interpolation = RigidbodyInterpolation.Interpolate;
        rigidbody.collisionDetectionMode = CollisionDetectionMode.Continuous;
    }
}
