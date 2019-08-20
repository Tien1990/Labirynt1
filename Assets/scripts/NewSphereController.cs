using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewSphereController : MonoBehaviour
{
   
    void Start()
    {
        
    }

    
    void Update()
    {
        var direction = Vector3.zero;

        if (Input.GetKey(KeyCode.UpArrow))
            direction = Vector3.forward;
    }
}
