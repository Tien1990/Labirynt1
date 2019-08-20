using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Direction : MonoBehaviour
{

    public bool rightDirection = true;
   void OnTriggerStay(Collider collision)
    {
        GameObject thing = collision.gameObject;
        Rigidbody rigidbody = thing.GetComponent<Rigidbody>();
        Vector3 velocity = rigidbody.velocity;


        if(rightDirection)
        {
            velocity.z = 5f;
        }
        else
        {
            velocity.z = -5f;
        }

        velocity.z = 5f;
        rigidbody.velocity = velocity;
    }
}
