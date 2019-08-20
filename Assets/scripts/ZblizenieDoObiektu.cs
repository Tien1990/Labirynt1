using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZblizenieDoObiektu : MonoBehaviour
{
    void OnTriggerStay(Collider collision) {
      if(collision.gameObject.name == "Sphere") 
      {
        GetComponent<Renderer>().enabled = true;
       
      }
      }
    void OnTriggerExit(Collider collision){
             {
              GetComponent<Renderer>().enabled = false;
             }
}
    
  
}
