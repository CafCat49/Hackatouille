using System;
using UnityEngine;
using UnityEngine.EventSystems;

public class Interactable : MonoBehaviour, IPointerDownHandler, IPointerEnterHandler, IPointerExitHandler
{
    bool activated = false;
    public string InteractionType = "";
    public static Action<string> OnActivate;
    public static Action<string> OnDeactivate;
    public static Action OnMouseOverlap;
    public static Action OnMouseEndOverlap;
    
    public void OnPointerDown(PointerEventData eventData)
    {
        //Temporary functionality for testing purpose
        Debug.Log("I have been clicked OwO");
        
        if (!activated)
        {
            activated = true;
            OnActivate?.Invoke(InteractionType);
        }
        else
        {
            activated = false;
            OnDeactivate?.Invoke(InteractionType);
        }
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        if (InteractionType == "Computer")
        {
            OnMouseOverlap?.Invoke();
        }
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        if (InteractionType == "Computer")
        {
            OnMouseEndOverlap?.Invoke();
        }
    }
}
