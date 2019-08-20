using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Crystal : MonoBehaviour
{
    public GameObject particles;

    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.name != "Sphere")
        {

            var audioSource = GetComponent<AudioSource>();
            audioSource.Play();
            return;
        }

        if (leaveCrystals() == 1)
        {
            string levelName = Application.loadedLevelName;
            PlayerPrefs.SetInt(levelName + "_finished", 1);

            SceneManager.LoadScene("Menu");

        }
        else
        {

            Instantiate(particles, transform.position, Quaternion.identity);
            Destroy(gameObject, 0.1f);
        }
    }

    int leaveCrystals()
    {
        Crystal[] crystals = Component.FindObjectsOfType<Crystal>();
        return crystals.Length;
    }
}      