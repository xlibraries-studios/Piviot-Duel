using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RingHolderMovement : MonoBehaviour
{
    public float rotateSpeed = 5.0f;

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetMouseButtonDown(0))
        //{
        //    OnMosueDown();
        //}
        this.transform.Rotate(Vector3.forward * rotateSpeed * Time.deltaTime);
        //Debug.Log("Rotate");
    }

    //private void OnMosueDown()
    //{
    //    this.transform.Rotate(Vector3.forward * rotateSpeed * Time.deltaTime);
    //    Debug.Log("Rotate");
    //}
}
