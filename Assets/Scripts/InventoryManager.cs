using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    public RectTransform rect;

    public GameObject Panel;
    public GameObject Button;
    bool isActive = false;

    private void Update()
    {
        if (Input.GetButtonDown("Inventory"))
        {
            Debug.Log("Abriendo");
            InventoryToggle();
        }
    }
    public void InventoryToggle()
    {
        if (Panel != null)
        {
            if (!isActive)
            {
                Panel.SetActive(true);
                Button.SetActive(false);
                isActive = true;
            }
            else if (isActive)
            {
                Panel.SetActive(false);
                Button.SetActive(true);
                isActive = false;
            }
        }
    }

    
}
