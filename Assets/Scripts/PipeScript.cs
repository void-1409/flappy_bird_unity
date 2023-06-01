using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeScript : MonoBehaviour
{
    public float pipeSpeed = 5;
    private float killPosition = -55.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * pipeSpeed) * Time.deltaTime;
        if (transform.position.x < killPosition)
            Destroy(gameObject);
    }
}
