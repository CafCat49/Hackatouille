using UnityEngine;
using UnityEngine.EventSystems;

public class Interactable : MonoBehaviour, IPointerDownHandler
{
    bool activated = false;
    
    public static System.Action OnInteract;
    
    public void OnPointerDown(PointerEventData eventData)
    {
        //Temporary functionality for testing purpose
        Debug.Log("I have been clicked OwO");
        
        if (!activated)
        {
            GetComponent<SpriteRenderer>().color = Color.green;
            activated = true;
            OnInteract?.Invoke();
        }
        else
        {
            GetComponent<SpriteRenderer>().color = Color.red;
            activated = false;
        }
    }
}
