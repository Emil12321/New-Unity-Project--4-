using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class button1 : MonoBehaviour
{
    public bool yes;
    public bool click = false;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (yes == true)
        {
            if (Input.GetMouseButtonDown(0)) {
                click = true;
            }
        }

        if (click == true)
        {
            GameObject.Find("texts 1").GetComponent<Text>().text = ("hej");
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
