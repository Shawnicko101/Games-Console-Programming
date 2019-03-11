using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    public GameObject Freeze,Bike;
    public float speed = 20.0f, speedHori = 4.0f;
    public float rotationSpeed = 90f, scale = 0f, rotation;
    public bool ramp = false;
    public float power_cooldown = 4.0f;
    public float last_Power = 0.0f;


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
            Ability();


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
        if (Input.GetButton("Rotate"))
        {
            GetComponent<Transform>().eulerAngles = new Vector3(0, transform.eulerAngles.y, 0);
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

    public void OnTriggerEnter(Collider other3)
    {
        if (other3.gameObject.tag == "Coin")
        {
            Destroy(other3.gameObject);

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

    public void Ability()
    {
        if (Input.GetKey(KeyCode.Q))
        {

            if (Time.time - last_Power < power_cooldown)
            {
                return;
            }

            Instantiate(Freeze, gameObject.transform.position + (transform.forward * 2), Quaternion.Euler(90, 0, 0));
            last_Power = Time.time;
        }
    }
}
