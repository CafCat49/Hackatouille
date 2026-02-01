using System;
using UnityEngine;
using UnityEngine.EventSystems;

public class Interactable : MonoBehaviour, IPointerDownHandler
{
    bool activated = false;
    public string InteractionType = "";
    public static Action<string> OnActivate;
    public static Action<string> OnDeactivate;
    
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
}
