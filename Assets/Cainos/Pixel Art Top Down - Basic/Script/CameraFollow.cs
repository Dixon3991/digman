
using UnityEngine;


    //let camera follow target
    public class CameraFollow : MonoBehaviour
    {
       public Transform target;

       public float smoothSpeed = 0.125f;
       public Vector3 offset;

       void LateUpdate ()
       {

        transform.position = target.position + offset;

       }

    }

