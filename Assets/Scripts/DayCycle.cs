using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayCycle : MonoBehaviour
{

    [Tooltip("Number of minutes per second that pass, 60 by default")]
    [SerializeField] float minutesPerSecond = 60f;  // Like in real world

    
    // Update is called once per frame
    void Update()
    {
        float angleThisFrame = (Time.deltaTime / 360) * minutesPerSecond; // Maybe need to edit.
        transform.RotateAround(transform.position, Vector3.forward, angleThisFrame);
    }
}
