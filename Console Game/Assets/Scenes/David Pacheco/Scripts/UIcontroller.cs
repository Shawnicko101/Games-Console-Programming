using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class UIcontroller : MonoBehaviour {

    public int uiNum;
    public Button[] buttons;

    public EventSystem eventSys;
    private float lastUpdate = 0;
    private float updateRate = 0.25f;

	void Start () {
		


	}
	
	void Update () {

        if (Time.time > lastUpdate + updateRate)
        {
            OnPressUp();
            OnPressDown();
            lastUpdate = Time.time;
        }


        //buttons[uiNum].Select();

        eventSys.SetSelectedGameObject(buttons[uiNum].gameObject);

        if (Input.GetButtonDown("Select"))
        {
            eventSys.currentSelectedGameObject.GetComponent<Button>().onClick.Invoke();
        }


	}

    void OnPressUp()
    {
        if (Input.GetAxis("Vertical") > 0.1)
        {
            uiNum++;
            uiNum = Mathf.Clamp(uiNum, 0, buttons.Length - 1);
        }
    }

    void OnPressDown()
    {
        if (Input.GetAxis("Vertical") < -0.1)
        {
            uiNum--;
            uiNum = Mathf.Clamp(uiNum, 0, buttons.Length - 1);
        }
    }

    void DoShit()
    {
        // Index = 0;
        // List of Buttons

        /*
        void OnUp()
        {
            index++
        }

        void OnDown()
        {
            index--
        }

        void Update()
        {
            if (input = up)
               OnUp
              
            if (input = down
                OnDown

            Eventsystem = ButtonsList[Index]

            if (accept button is presseD)
                buttonList[index].OnClick()
        }

         * */
    }
}
