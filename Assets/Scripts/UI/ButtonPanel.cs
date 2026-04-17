using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPanel : MonoBehaviour
{
   public GameObject Panel;
    public GameObject Button;
    bool isActive = false;

    public void PanelToggle()
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
