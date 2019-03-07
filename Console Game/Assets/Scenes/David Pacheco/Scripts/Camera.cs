using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour {

    public Transform cameraSpot;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

            transform.position = Vector3.MoveTowards(transform.position, cameraSpot.position, 3 * Time.deltaTime);

    }
}
