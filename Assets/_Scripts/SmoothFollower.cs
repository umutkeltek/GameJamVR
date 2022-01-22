using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmoothFollower : MonoBehaviour
{
    // camera will follow this object
    public Transform Target;
    //camera transform
    public Transform camTransform;
    // change this value to get desired smoothness
    public float SmoothTime = 0.3f;
 
    // This value will change at the runtime depending on target movement. Initialize with zero vector.
    private Vector3 velocity = Vector3.zero;
 
    private void LateUpdate()
    {
        // update position
        transform.position = Vector3.SmoothDamp(transform.position, Target.position, ref velocity, SmoothTime);
 
        // update rotation
        transform.LookAt(camTransform);
    }
}
