using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    public float speed = 20.0f, speedHori = 4.0f;
    public float rotationSpeed = 90f, scale = 0f, rotation;
    public bool ramp = false;
    public float jumpHeight = 70f;
    private Rigidbody rb;
    public float downTime = 0;
    public float coolDownTime = 2;
    public bool lavaSpeed = false;

    void Start () {
        rb = GetComponent<Rigidbody>();
		
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
            transform.Rotate(0, rotation * translation * (10f / 1.5f), 0);
        }
        if (Input.GetButton("Jump") && Time.time > downTime)
        {
        
            rb.AddForce(Vector3.up * jumpHeight, ForceMode.Impulse);
            downTime = Time.time + coolDownTime;
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
        if (other.gameObject.tag == "Lava")
        {
            Debug.Log("it work?");
            lavaSpeed = true;
            speed = 1;
            jumpHeight = 10;

        }
    }

    public void OnTriggerExit(Collider other2)
    {
        if (other2.gameObject.tag == "Ramp")
        {
            ramp = false;
            scale = 0;


        }
        if (other2.gameObject.tag == "Lava")
        {
            lavaSpeed = false;
        }
    }




    public void OnButtonPress()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            rotationSpeed = 85f;
            speed = 7.5f;
            float translation = Input.GetAxis("Horizontal") * (speedHori * Input.GetAxis("Vertical"));
            translation *= Time.deltaTime;
            transform.Translate(-translation , 0, 0);
        }
        else if (!Input.GetKey(KeyCode.LeftShift)&& lavaSpeed == false)
        {

            rotationSpeed = 90f;
            speed = 20.0f;
        }
    }

   
}
