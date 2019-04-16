using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraForward : MonoBehaviour
{

    public float speed = 5000.0f;
    public GameObject player1;
    Rigidbody rb;
    //public Camera cam;
    public float rotationSpeed = 90f, rotation;
    public bool ramp = false;
    public GameObject camRight;
    public GameObject camDefault;

    // Use this for initialization
    void Start()
    {
        player1 = GameObject.Find("Player 1");
        rb = player1.GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        float translation = Input.GetAxis("Vertical") * speed;

        translation *= Time.deltaTime;

        if (Input.GetAxis("Vertical") != 0)
        {
            rb.AddForce(transform.forward * translation);
            print(translation);
           
            
        }

        if (Input.GetKey(KeyCode.LeftShift) && Input.GetAxis("Horizontal") > 0.1f)
        {
            transform.position = camRight.transform.position;
            transform.rotation = camRight.transform.rotation;
        }
        else{
            transform.position = camDefault.transform.position;
            transform.rotation = camDefault.transform.rotation;
        }
    }
}
