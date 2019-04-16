using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestPickup : MonoBehaviour {

    public float speed = 20.0f;
    public GameObject player1;
    public Rigidbody rb;
    public Camera cam;

	// Use this for initialization
	void Start () {
        player1 = GameObject.Find("Player 1");
        rb = player1.GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        float translation = Input.GetAxis("Vertical") * speed;

        translation *= Time.deltaTime;

        if(Input.GetAxis("Vertical") != 0)
        {
            rb.AddForce(cam.transform.forward * translation);
        }
    }
}
