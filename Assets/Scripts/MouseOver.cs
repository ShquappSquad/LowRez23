using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MouseOver : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler
{
    // Start is called before the first frame update
    public void OnPointerEnter(PointerEventData eventData)
    {
        Debug.Log("Mouse is over the Ship");
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        Debug.Log("Mouse is NOT over the Ship");
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("The ship has been clicked on");
    }
}
