using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    private int InteractableCount;
    private int TotalInteracted = 0;
    
    public string VictoryScene = "";
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Interactable.OnActivate += OnInteracted;
        Interactable.OnDeactivate += OnDeactivated;
        InteractableCount = FindObjectsByType<Interactable>(FindObjectsSortMode.None).Length;
    }

    private void OnInteracted()
    {
        TotalInteracted++;
        Debug.Log(TotalInteracted >= InteractableCount
            ? "You have found all interactables, good girl!"
            : "Keep going, sweetie");

        if (TotalInteracted >= InteractableCount)
        {
            SceneManager.LoadScene(VictoryScene);
        }
    }

    private void OnDeactivated()
    {
        if (TotalInteracted > 0) TotalInteracted -= 1;
    }

    void OnDestroy()
    {
        Interactable.OnActivate -= OnInteracted;
        Interactable.OnDeactivate -= OnDeactivated;
    }
}
