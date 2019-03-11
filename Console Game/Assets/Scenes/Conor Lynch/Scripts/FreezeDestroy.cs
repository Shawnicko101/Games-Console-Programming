using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreezeDestroy : MonoBehaviour {

    float timer = 0;

	void Start () {
		
	}
	
	void Update () {

        timer += Time.deltaTime;

        if (timer > 5)
        {
            Destroy(gameObject);
        }

	}
}
