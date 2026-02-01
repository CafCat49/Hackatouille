using System;
using UnityEngine;
using UnityEngine.EventSystems;

public class Interactable : MonoBehaviour, IPointerDownHandler
{
    bool activated = false;
    public string InteractionType = "";
    public static Action<string> OnActivate;
    public static Action OnDeactivate;
    
    public void OnPointerDown(PointerEventData eventData)
    {
        //Temporary functionality for testing purpose
        Debug.Log("I have been clicked OwO");
        
        if (!activated)
        {
            GetComponent<SpriteRenderer>().color = Color.green;
            activated = true;
            OnActivate?.Invoke(InteractionType);
        }
        else
        {
            GetComponent<SpriteRenderer>().color = Color.red;
            activated = false;
            OnDeactivate?.Invoke();
        }
    }
}
