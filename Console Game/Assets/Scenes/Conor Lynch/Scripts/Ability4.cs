using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ability4 : MonoBehaviour
{
    public float Abilityduration = 4f;
    float timer;

    GameObject player;

    // Use this for initialization
    void Start()
    {
        player = GameObject.FindWithTag("Player");
        timer = Abilityduration;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            Destroy(this.gameObject);
        }


        transform.position = player.transform.position;


    }

}
