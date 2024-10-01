using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public Material materialNormal;
    public Material materialFreeze;
    private MeshRenderer meshBall;

    private CanvasGameMng canvasGameMng;
    private Rigidbody rigidbodyBall;
    public float gravity = -5;
    // Start is called before the first frame update
    void Start()
    {
        canvasGameMng = FindObjectOfType<CanvasGameMng>();
        rigidbodyBall = GetComponent<Rigidbody>();
        meshBall = GetComponent<MeshRenderer>();
        meshBall.material = new Material(materialNormal);
    }

    // Update is called once per frame
    void Update()
    {
        if (rigidbodyBall == null) return;

        if(canvasGameMng.isDisableInteraction == true)
        {
            GetComponent<Rigidbody>().isKinematic = true;
        }
        else
        {
            rigidbodyBall.velocity = new Vector3(rigidbodyBall.velocity.x,gravity,rigidbodyBall.velocity.z);
        }
    }

    public void DisableGravity()
    {
        meshBall.material = new Material(materialFreeze);
        Destroy(rigidbodyBall);
    }

    public void EnableGravity()
    {
        meshBall.material = new Material(materialNormal);
        rigidbodyBall = gameObject.AddComponent<Rigidbody>();
        rigidbodyBall.interpolation = RigidbodyInterpolation.Interpolate;
        rigidbodyBall.collisionDetectionMode = CollisionDetectionMode.Continuous;
    }
}
