using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbilityMaster : MonoBehaviour {
    public GameObject ability1;
    public GameObject ability2;
    public GameObject ability3;
    public GameObject ability4;
    public GameObject ability5;
    public float power_cooldown = 4.0f;
    public float last_Power = 0.0f;
    public float downTime = 0;
    public float coolDownTime = 2;
    public float jumpHeight = 70f;
    public GameObject parent;
    CharacterSelect charSelect = new CharacterSelect();

    // Use this for initialization
    void Start () {
       charSelect = parent.GetComponent<CharacterSelect>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Ability1()
    {
        if (Input.GetKey(KeyCode.Q))
        {

            if (Time.time - last_Power < power_cooldown)
            {
                return;
            }

            Instantiate(ability1, gameObject.transform.position + (transform.forward * -7), Quaternion.Euler(90, 0, 0));
            last_Power = Time.time;
        }
    }

    public void Ability2()
    {
        if (Input.GetKey(KeyCode.Q) && Time.time > downTime)
        {

            Instantiate(ability2, gameObject.transform.position + (transform.forward * 2), Quaternion.Euler(90, 90, 90));
            rb.AddForce(Vector3.up * jumpHeight, ForceMode.Impulse);
            downTime = Time.time + coolDownTime;

        }
    }

    public void Ability3()
    {
        if (Input.GetKey(KeyCode.Q))
        {

            if (Time.time - last_Power < power_cooldown)
            {
                return;
            }

            Instantiate(ability3, gameObject.transform.position + (transform.forward * -7), Quaternion.Euler(90, 0, 0));
            last_Power = Time.time;
        }
    }

    public void Ability4()
    {
        if (Input.GetKey(KeyCode.Q))
        {

            if (Time.time - last_Power < power_cooldown)
            {
                return;
            }

            Instantiate(ability4, gameObject.transform.position + (transform.forward * 2), Quaternion.Euler(90, 90, 90));
            last_Power = Time.time;
        }
    }

    public void Ability5()
    {
        if (Input.GetKey(KeyCode.Q))
        {

            if (Time.time - last_Power < power_cooldown)
            {
                return;
            }

            Instantiate(ability5, gameObject.transform.position + (transform.forward * -3), Quaternion.Euler(180, 0, 0));
            last_Power = Time.time;
        }
    }
}
