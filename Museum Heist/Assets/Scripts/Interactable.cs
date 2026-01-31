using UnityEngine;
using UnityEngine.EventSystems;

public class Interactable : MonoBehaviour, IPointerDownHandler
{
    bool activated = false;
    
    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("I have been clicked OwO");
        
        if (!activated)
        {
            GetComponent<SpriteRenderer>().color = Color.green;
            activated = true;
        }
        else
        {
            GetComponent<SpriteRenderer>().color = Color.red;
            activated = false;
        }
    }
}
