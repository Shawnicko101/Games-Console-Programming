using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour {

    public Transform target;
    public Vector3 offset;
    public float speed;

    // Use this for initialization
    void Start () {
        speed = 20.0f;
	}
	
	// Update is called once per frame
	void Update () {

        transform.position = Vector3.MoveTowards(transform.position, target.position + offset, speed * Time.deltaTime);
        transform.LookAt(target);

    }
}
