using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    public float speed = 10.0f;
    public float rotationSpeed = 100f, scale = 0f, rotation;
    public bool ramp = false;

	void Start () {
		
	}
	
	void Update () {

        OnButtonPress();

        float translation = Input.GetAxis("Vertical") * speed;

        translation *= Time.deltaTime;
        transform.Translate(0, 0, translation);

        if (!ramp)
        {
            rotation = Input.GetAxis("Horizontal") * rotationSpeed;


            rotation *= Time.deltaTime;
            transform.Rotate(0, rotation * translation * (speed / 1.5f), 0);
        }
    }

    public void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Ramp")
        {
            transform.rotation = Quaternion.Slerp(gameObject.transform.rotation, Quaternion.identity, scale);
            ramp = true;

            scale += 0.05f * Time.deltaTime;
        }
    }

    public void OnTriggerExit(Collider other2)
    {
        if (other2.gameObject.tag == "Ramp")
        {
            ramp = false;

        }
    }

    public void OnButtonPress()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            rotationSpeed = 150f;
        }
        else if (!Input.GetKey(KeyCode.LeftShift))
        {
            rotationSpeed = 100f;
        }
    }
}
