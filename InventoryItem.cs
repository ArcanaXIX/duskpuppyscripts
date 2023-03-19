using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]

public class InventoryItem : MonoBehaviour
{
    public GameObject inventoryText;

    public void OnMouseDown()
    {
        inventoryText.SetActive(true);
    }
}
