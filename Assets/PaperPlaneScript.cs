using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaperPlaneScript : MonoBehaviour
{
    public Rigidbody2D planeRigidBody;
    public float flightStrength;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true)
        {
            planeRigidBody.velocity = Vector2.up * flightStrength;
        }
    }
}
