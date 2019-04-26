using System.Collections;
using System.Collections.Generic;
using UnityEngine;
<<<<<<< HEAD
using UnityEngine.UI;

public class CharacterSelect : MonoBehaviour {
    public Image Character1, Character2, Character3, Character4, Character5, Ability1, Ability2, Ability3, Ability4, Ability5;
    public Text abilityName, currentPlayer;
    int CharacterNumber = 0;

    public int ChosenCharacter = 0, ChosenCar = 0;

    // Use this for initialization
    void Start () {
=======

public class CharacterSelect : MonoBehaviour {

	// Use this for initialization
	void Start () {
>>>>>>> 7bfa9eeb2ce9c496f249b71352effa66a39ef33d
		
	}
	
	// Update is called once per frame
	void Update () {
<<<<<<< HEAD
        ChangeCharacter();

        if (Input.GetKeyDown(KeyCode.Tab))
        {
            if (CharacterNumber <= 3)
            {
                CharacterNumber++;
            }
            else if (CharacterNumber >= 4)
            {
                CharacterNumber = 0;
            }
        }

        else if (Input.GetKeyDown(KeyCode.Return))
        {
            ChosenCharacter = CharacterNumber;
        }

	}

    public void ChangeCharacter()
    {
        switch(CharacterNumber)

        {
            case 0:
                Character1.enabled = true;
                Character2.enabled = false;
                Character5.enabled = false;
                Ability1.enabled = true;
                Ability2.enabled = false;
                Ability5.enabled = false;

                abilityName.text = "Water Ability";
                break;
            case 1:
                Character1.enabled = false;
                Character2.enabled = true;
                Character3.enabled = false;
                Ability1.enabled = false;
                Ability2.enabled = true;
                Ability3.enabled = false;

                abilityName.text = "Fire Ability";
                break;
            case 2:
                Character2.enabled = false;
                Character3.enabled = true;
                Character4.enabled = false;
                Ability2.enabled = false;
                Ability3.enabled = true;
                Ability4.enabled = false;

                abilityName.text = "Freeze Ability";
                break;
            case 3:
                Character3.enabled = false;
                Character4.enabled = true;
                Character5.enabled = false;
                Ability3.enabled = false;
                Ability4.enabled = true;
                Ability5.enabled = false;

                abilityName.text = "Storm Ability";

                break;
            case 4:
                Character1.enabled = false;
                Character4.enabled = false;
                Character5.enabled = true;
                Ability4.enabled = false;
                Ability5.enabled = true;
                Ability1.enabled = false;

                abilityName.text = "Lightning Ability";
                break;
        }
    }
}

=======
		
	}
}
>>>>>>> 7bfa9eeb2ce9c496f249b71352effa66a39ef33d
