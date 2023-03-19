using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelDemo : MonoBehaviour
{

    public GrabObject warmCoffee;
    public GameObject hotCoffeeInvent;
    private int tracker;
    private bool progressing;

    public void Progression()
    {
        progressing = true; //will trigger something to happen at end of frame: see below
        if (tracker == 0) //first progression trigger makes warm coffee gettable
        {
            warmCoffee.itemGettable = true;
        }
        else if (tracker == 1) //second progression trigger turns off the hot coffee inventory item b/c it is replaced with the warm coffee 
        {
            hotCoffeeInvent.SetActive(false);
        }
    }

    private void LateUpdate() // very last thing to happen
    {
        if (progressing == true) //adds the tracker counter so the next Progression() method does the next thing in line
        {
            tracker++;
            progressing = false;
        }
    }

}
