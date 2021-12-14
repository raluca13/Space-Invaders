using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform target;
    //public Transform followTransform;
    public float smoothSpeed = 0.125f;
    public Vector3 offset;

    //void FixedUpdate()
    // { this.transform.position = new Vector3(target.position.x, target.position.y, this.transform.position.z); }

    void FixedUpdate()
    {
        Vector3 desiredPosition = target.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;

       
    }

}

    //private void SetCameraPosition()
    //{
     
    //{ this.transform.position = new Vector3(target.position.x, target.position.y, this.transform.position.z); }
    //}

 
    

    

    


