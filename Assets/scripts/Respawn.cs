using UnityEngine;
using System.Collections;

public class Respawn : MonoBehaviour
{
    public GameObject ballPrefab;
    public Camera cameraPrefab;
    public Light lightPrefab;

    public GameObject gameOverBase;
    

    void Start()
    {
        GameObject sphere = GameObject.Instantiate(ballPrefab);
        sphere.name = "Sphere";
        sphere.transform.position = transform.position + Vector3.up * 2f;

        Camera camera = GameObject.Instantiate(cameraPrefab);
        CameraControl cameraController = camera.GetComponent<CameraControl>();
        cameraController.sphere = sphere.transform;

        Light light = GameObject.Instantiate(lightPrefab);

        light.color = Color.white;
        light.intensity = 0.5f;
        RenderSettings.ambientMode = UnityEngine.Rendering.AmbientMode.Flat;
        RenderSettings.ambientLight = Color.white * 0.7f;

        GameObject.Instantiate(gameOverBase);
       
    }

    void Update()
    {
       
    }

  
}
