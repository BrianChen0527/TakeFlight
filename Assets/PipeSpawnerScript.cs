using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnerScript : MonoBehaviour
{
    public GameObject pipes;
    public float spawnRate = 2;
    public float heightOffset = 4;

    private float timer = 0;

    // Start is called before the first frame update
    void Start()
    {
        SpawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        SpawnPipe();
    }

    void SpawnPipe()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            float lowestPoint = transform.position.y - heightOffset;
            float highestPoint = transform.position.y + heightOffset;

            timer = 0;
            Instantiate(pipes, new Vector3(transform.position.x, 
                Random.Range(lowestPoint, highestPoint), 0), transform.rotation);
        }
    }
}
