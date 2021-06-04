using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RingMove : MonoBehaviour
{
    public float speed = 10f;
    public float rotateSpeed = 0.001f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * speed * Time.deltaTime, Space.World);
        if(Input.GetMouseButtonUp(0))
        {
            transform.Rotate(0, 0, rotateSpeed * Time.deltaTime);
        }

    }
}
