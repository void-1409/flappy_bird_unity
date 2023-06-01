using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPipeScript : MonoBehaviour
{
    public GameObject pipe;
    public float spawnRate = 2.0f;
    public float heightOffset = 18.0f;
    private float spawnTime = 0;

    // Start is called before the first frame update
    void Start()
    {
        spawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (spawnTime < spawnRate)
        {
            spawnTime = spawnTime + Time.deltaTime;
        }
        else
        {
            spawnPipe();
            spawnTime = 0;
        }
    }

    void spawnPipe()
    {
        float topPoint = transform.position.y + heightOffset;
        float bottomPoint = transform.position.y - heightOffset;

        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(bottomPoint, topPoint), 0), transform.rotation);
    }
}
