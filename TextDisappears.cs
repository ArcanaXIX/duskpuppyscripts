using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextDisappears : MonoBehaviour
{
    public GameObject thisText;
    private void OnMouseDown()
    {
        thisText.SetActive(false);
    }
}
