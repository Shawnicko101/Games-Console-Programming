using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CarSelect : MonoBehaviour {
    public Image Character1, Character2, Character3, Character4, Character5;
    public Text currentPlayer;
    int CarNumber = 0;

    public int ChosenCar = 0;

    void Start () {
		
	}
	
	void Update () {
        ChangeCar();

        if (Input.GetKeyDown(KeyCode.Tab))
        {
            if (CarNumber <= 3)
            {
                CarNumber++;
            }
            else if (CarNumber >= 4)
            {
                CarNumber = 0;
            }
        }

        else if (Input.GetKeyDown(KeyCode.Return))
        {
            ChosenCar = CarNumber;
        }
    }

    public void ChangeCar()
    {
        switch (CarNumber)

        {
            case 0:
                Character1.enabled = true;
                Character2.enabled = false;
                Character5.enabled = false;
                break;
            case 1:
                Character1.enabled = false;
                Character2.enabled = true;
                Character3.enabled = false;
                break;
            case 2:
                Character2.enabled = false;
                Character3.enabled = true;
                Character4.enabled = false;
                break;
            case 3:
                Character3.enabled = false;
                Character4.enabled = true;
                Character5.enabled = false;

                break;
            case 4:
                Character1.enabled = false;
                Character4.enabled = false;
                Character5.enabled = true;
                break;
        }
    }
}
