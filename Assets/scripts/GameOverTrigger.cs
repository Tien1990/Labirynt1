using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverTrigger : MonoBehaviour
{
   /* void OnTriggerEnter(Collider collision)
    {

        if (collision.gameObject.name == "sphere")
        {
            string levelName = Application.loadedLevelName;
            Application.loadLevel(levelName);
        }
    }*/

    void OnTriggerEnter(Collider collision)
        {
        if(collision.gameObject.name == "Sphere")
            {
            string levelName = Application.loadedLevelName;
            SceneManager.LoadScene(levelName);
            }
        
        }

}
