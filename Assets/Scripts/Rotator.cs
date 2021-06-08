using UnityEngine;

public class Rotator : MonoBehaviour
{
    public float rotateSpeed = 200.0f;

    // Update is called once per frame
    void Update()
    {
        this.transform.Rotate(Vector3.forward * rotateSpeed * Time.deltaTime);
    }
}
