using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleRotation : MonoBehaviour {

    Transform target;

    public float timer = 0;

	void Start () {
        target = GameObject.FindWithTag("MainCamera").transform;
	}
	
	void Update () {

        timer += Time.deltaTime;

        transform.LookAt(target);
        transform.Translate(Vector3.up * 2 * Time.deltaTime, Space.World);

        if (timer >= 3)
        {
            Destroy(gameObject);
        }


    }
}
