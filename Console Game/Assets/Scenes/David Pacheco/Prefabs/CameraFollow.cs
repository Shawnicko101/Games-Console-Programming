using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject player1;
    public GameObject location;
    public GameObject camera;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        camera.transform.position = Vector3.Lerp(camera.transform.position, location.transform.position, 5);
        //camera.transform.position = location.transform.position;
        camera.transform.LookAt(player1.transform);
    }
}
