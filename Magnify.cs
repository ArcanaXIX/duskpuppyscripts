using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Magnify : MonoBehaviour
{
    public AudioSource glassesOn;
    public AudioSource glassesOff;
    public GameObject interactibles;
    bool magnifyingGlass = false;
    public void OnMouseDown()
    {
        if (magnifyingGlass == true)
        {
            glassesOff.Play();
            magnifyingGlass = false;
            interactibles.SetActive(false);
        }
        else
        {
            glassesOn.Play();
            magnifyingGlass = true;
            interactibles.SetActive(true);
        }
    }

}
