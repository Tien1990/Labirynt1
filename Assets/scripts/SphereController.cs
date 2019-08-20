using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereController : MonoBehaviour
{

    public float Speed = 5f;

    void Start()
    {
       
    }



    void FixedUpdate()
    {
        var direction = Vector3.zero;


        if (Input.GetKey(KeyCode.UpArrow))
            direction += Vector3.forward;

        if (Input.GetKey(KeyCode.DownArrow))
            direction += Vector3.back;

        if (Input.GetKey(KeyCode.RightArrow))
            direction += Vector3.right;

        if (Input.GetKey(KeyCode.LeftArrow))
            direction += Vector3.left;

        GetComponent<Rigidbody>().AddForce(direction * Speed);
}
    }



/* 
 * Stare sterowanie
 * 
 * Rigidbody rigidbody = transform.GetComponent<Rigidbody>();

        

       if (Input.GetKey(KeyCode.UpArrow))
        {

            rigidbody.AddTorque(-Vector3.left*100f);
        }

       if (Input.GetKey(KeyCode.DownArrow))
        {
            rigidbody.AddTorque(Vector3.left*100f);
        }

       if (Input.GetKey(KeyCode.LeftArrow))
        {
            rigidbody.AddTorque(Vector3.forward*100f);
        }

       if (Input.GetKey(KeyCode.RightArrow))
        {
            rigidbody.AddTorque(-Vector3.forward*100f);
            }
 * 
            
     
     */
