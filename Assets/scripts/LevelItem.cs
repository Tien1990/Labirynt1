using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class LevelItem : MonoBehaviour
{
    public TextMesh textMesh;
    public string levelName;
    public GameObject okey;

     void Start()
    {
        textMesh.text = levelName;

        if(PlayerPrefs.GetInt(levelName+"_finished",0) == 0)
        {
            Destroy(okey);
        }
    }

     void OnMouseDown()
    {
        Application.LoadLevel(levelName);
    }
}
