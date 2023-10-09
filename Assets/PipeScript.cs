using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeScript : MonoBehaviour
{
    public float moveSpeed = 5.0f;
    public float deadZone = -20;

    // Start is called before the first frame update
    void Start()
    {

        UnityEngine.Debug.Log("Hello");
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < deadZone)
        {
            UnityEngine.Debug.Log("Pipe destroyed...");
            Destroy(gameObject);
        }

        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;
    }
}
