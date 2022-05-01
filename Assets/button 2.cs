using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class sc : MonoBehaviour
{
    public button1 btn;
    bool yes;
    bool click;

    private string letter1;
    private string letter2;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        letter1 = "t";
        letter2 = "a";
        if (yes == true)
        {
            if (Input.GetMouseButtonDown(0)) {
                click = true;
            }
        }
        
        if (click == true && btn.click == true)
        {
            GameObject.Find("texts 2").GetComponent<Text>().text = (letter1);
        }

        

    }
    public void OnMouseEnter()
    {

        yes = true;

    }

    public void OnMouseExit()
    {
        yes = false;
    }
}
