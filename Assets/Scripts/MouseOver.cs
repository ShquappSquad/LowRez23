using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

//The functions below will execute on whatever object they are attached to. In order for them to be detected the object
//needs to have a collider and that collider has to be part of the event system.

public class MouseOver : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler
{
    //Triggers when mouse hovers over attached object
    public void OnPointerEnter(PointerEventData eventData)
    {
        Debug.Log("Mouse is over the Ship");
    }

    //Triggers when mouse is no longer hovering over attached object
    public void OnPointerExit(PointerEventData eventData)
    {
        Debug.Log("Mouse is NOT over the Ship");
    }

    //Triggers when mplayer clicks on attached object
    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("The ship has been clicked on");
    }
}
