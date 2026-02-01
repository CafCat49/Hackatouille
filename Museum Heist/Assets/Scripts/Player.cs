using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public GameObject securityCam;
    private SpriteRenderer securityCamRenderer;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        securityCamRenderer = securityCam.GetComponent<SpriteRenderer>();
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
            case "Camera":
                if (securityCam && securityCamRenderer) securityCamRenderer.flipX = true;
                break;
            default:
                Debug.Log("No interaction type found");
                break;
        }
        
    }

    private void OnDeactivated(string interactionType)
    {
        if (interactionType == "Camera")
        {
            if (securityCam && securityCamRenderer) securityCamRenderer.flipX = false;
        }
    }

    void OnDestroy()
    {
        Interactable.OnActivate -= OnInteracted;
        Interactable.OnDeactivate -= OnDeactivated;
    }
}
