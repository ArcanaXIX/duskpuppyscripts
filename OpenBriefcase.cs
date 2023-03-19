using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenBriefcase : MonoBehaviour
{
   public AudioSource bagOpen;
   public AudioSource bagClose;
    public GameObject bagUI;
    bool bagclosed = true;
   public void OnMouseDown()
    {
        if (bagclosed == true)
        { bagOpen.Play();
            bagclosed = false;
            bagUI.SetActive(true);
        }
        else
        {
            bagClose.Play();
            bagclosed = true;
            bagUI.SetActive(false);
        }
    }
    
}
