using UnityEngine;

public class Player : MonoBehaviour
{
    private int InteractableCount;
    private int TotalInteracted = 0;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Interactable.OnInteract += OnInteractableInteracted;
        InteractableCount = FindObjectsByType<Interactable>(FindObjectsSortMode.None).Length;
    }

    private void OnInteractableInteracted()
    {
        TotalInteracted++;
        Debug.Log(TotalInteracted >= InteractableCount
            ? "You have found all interactables, good girl!"
            : "Keep going, sweetie");
    }

    void OnDestroy()
    {
        Interactable.OnInteract -= OnInteractableInteracted;
    }
}
