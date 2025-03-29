using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotator : MonoBehaviour
{
    // Rotation speed in degrees per second (33.3 RPM = 33.3 * 360 / 60)
    private float rotationSpeed = 33.3f * 360f / 60f;

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Update called");
        transform.Rotate(0, rotationSpeed * Time.deltaTime, 0);
    }
}
