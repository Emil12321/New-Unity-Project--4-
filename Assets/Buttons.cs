using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Buttons : MonoBehaviour
{
    public bool reset;
    public string currentLetter;
    public int currentTextSlot;
    public bool holding;
    public bool isFull;
    public bool starting;
    public bool clicked;
    // Start is called before the first frame update
    void Start()
    {
        currentTextSlot = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (currentTextSlot == 1)
        {
            starting = true;
        }

        Debug.Log(isFull);
        if (currentTextSlot == 3)
        {
            isFull = true;
        }
        if (currentTextSlot != 3)
        {
            isFull = false;
        }
    }
}
