using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleSpawn : MonoBehaviour {

    public Transform bubbles;
    public Transform bubbleSpawner1, bubbleSpawner2, bubbleSpawner3, bubbleSpawner4, bubbleSpawner5;
    public float timer = 0;
    public int randomNum = 0;

	void Start () {
		
	}
	
	void Update () {

        timer += Time.deltaTime;

        if (timer > 2.0f)
        {
            randomNum = Random.Range(0, 6);

            switch (randomNum)
            {

                case 1:
                    Instantiate(bubbles, bubbleSpawner1.position, Quaternion.identity);
                    timer = 0;
                    break;

                case 2:
                    Instantiate(bubbles, bubbleSpawner2.position, Quaternion.identity);
                    timer = 0;
                    break;

                case 3:
                    Instantiate(bubbles, bubbleSpawner3.position, Quaternion.identity);
                    timer = 0;
                    break;

                case 4:
                    Instantiate(bubbles, bubbleSpawner4.position, Quaternion.identity);
                    timer = 0;
                    break;

                case 5:
                    Instantiate(bubbles, bubbleSpawner5.position, Quaternion.identity);
                    timer = 0;
                    break;
            }
        }

	}
}
