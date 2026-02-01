using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Interactable.OnActivate += OnInteracted;
        Interactable.OnDeactivate += OnDeactivated;
    }

    private void OnInteracted(string interactionType)
    {
        switch (interactionType)
        {
            case "Computer":
                SceneManager.LoadScene("Windows2000Hacking");
                break;
            case "Password":
                SceneManager.LoadScene("PasswordScramble");
                break;
            default:
                Debug.Log("No interaction type found");
                break;
        }
        
    }

    private void OnDeactivated()
    {
        Debug.Log("Deactivated");
    }

    void OnDestroy()
    {
        Interactable.OnActivate -= OnInteracted;
        Interactable.OnDeactivate -= OnDeactivated;
    }
}
