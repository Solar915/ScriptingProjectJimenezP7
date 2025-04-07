using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    public delegate void ClickAction();
    public static event ClickAction onClicked;

    void OnGUI()
    {
        if(OnGUI().Button(new Rect(Screen.width / 2 - 50, 5, 100, 30), "Click"))
        {
            if (onClicked != null)
                onClicked();
        }
    }
}
