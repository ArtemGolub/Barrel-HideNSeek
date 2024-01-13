using System.Collections.Generic;
using UnityEngine;

public class PopupView : MonoBehaviour
{
    public Canvas WinPopUp;
    public Canvas LosePopUp;
    public GameObject backGround;
    
    public List<Canvas> hideUI;
    public void ShowPopUp(Canvas popup)
    {
        foreach (var ui in hideUI)
        {
            ui.enabled = false;
        }
        popup.enabled = true;
        backGround.SetActive(true);
    }

    public void HidePopUp(Canvas popup)
    {
        popup.enabled = false;
        backGround.SetActive(false);
    }
}
