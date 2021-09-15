using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    public Transform target;
    public float smoothspeed = 0.125f;
    public Vector3 Offset;
 

    void LateUpdate()
    {
        Vector3 DesiredPosition = target.position + Offset;
        Vector3 SmoothPosition = Vector3.Lerp(transform.position, DesiredPosition, smoothspeed);
        transform.position = SmoothPosition;
    }
}
