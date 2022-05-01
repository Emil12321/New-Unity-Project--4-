using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class btn2 : MonoBehaviour
{
    private Buttons buttons;
    bool yes;
    private bool click2;

    private string letter1;
    private string letter2;

    int clicks = 1;

    // Start is called before the first frame update
    void Start()
    {
        buttons = GameObject.Find("Buttons").GetComponent<Buttons>();
    }

    // Update is called once per frame
    void Update()
    {
        GameObject.Find("buttonText 2").GetComponent<Text>().text = ("A");

        if (yes == true)
        {

            if (Input.GetMouseButtonDown(0))
            {

                if (buttons.starting == true)
                {
                    GameObject.Find("texts 2").GetComponent<Text>().text = null;
                    GameObject.Find("texts 3").GetComponent<Text>().text = null;
                }

                if (buttons.isFull == true)
                {
                    GameObject.Find("texts 1").GetComponent<Text>().text = null;
                    GameObject.Find("texts 2").GetComponent<Text>().text = null;
                    GameObject.Find("texts 3").GetComponent<Text>().text = null;
                    buttons.currentTextSlot = 1;
                }
                click2 = true;
                buttons.holding = true;
            }
        }

        if (buttons.holding == true && Input.GetMouseButtonUp(0))
        {
            buttons.holding = false;
            buttons.reset = true;
            buttons.currentTextSlot = 1;
        }
        if (yes == true && buttons.holding == true)
        {
            GameObject.Find("texts " + buttons.currentTextSlot).GetComponent<Text>().text = (buttons.currentLetter);
        }

    }
    public void OnMouseEnter()
    {
        buttons.currentLetter = "A";
        if (buttons.isFull != true)
        {
            yes = true;
        } else
        {
            yes = false;
        }
        if (buttons.holding == true && buttons.isFull == false)
        {
            buttons.currentTextSlot += 1;
        }
    }

    public void OnMouseExit()
    {
        yes = false;
        click2 = false;
    }
}
