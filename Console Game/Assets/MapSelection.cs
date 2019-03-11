using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MapSelection : MonoBehaviour {

    public Image selection;
    public int green, blue;
    public bool greenT, blueT;

	void Start () {
		
	}
	
	void Update () {

        float translation = Input.GetAxis("Select");

        //if ()
        //{

        //}

        if (green < 255 && !greenT)
        {
            green++;
        }
        else if (green > 0)
        {
            green--;
        }

        if (blue <= 255)
        {
            blue++;
        }
        else if (blue >= 0)
        {
            blue--;
        }

        selection.color = new Color(255, green, blue);
    }
}
