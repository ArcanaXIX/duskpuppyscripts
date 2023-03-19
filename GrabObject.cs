using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GrabObject : MonoBehaviour
{
    public AudioSource itemGet;
    public GameObject itemObject;
    public GameObject itemDesc;
    public GameObject itemInventory;
    public GameObject itemHighlight;
    public bool itemGettable;

    public LevelDemo Level;

    public GameObject falseText;

    public void OnMouseDown()
    {
        if (itemGettable == true)
        {
            itemGet.Play();
            itemObject.SetActive(false);
            itemDesc.SetActive(true);
            itemInventory.SetActive(true);
            itemHighlight.SetActive(false);
            Level.Progression();
        }
        else
        {
            falseText.SetActive(true);
        }
    }

}