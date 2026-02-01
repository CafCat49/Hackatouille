using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public GameObject securityCam, computer;
    private SpriteRenderer securityCamRenderer, computerRenderer;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        securityCamRenderer = securityCam.GetComponent<SpriteRenderer>();
        computerRenderer = computer.GetComponent<SpriteRenderer>();
        Interactable.OnActivate += OnInteracted;
        Interactable.OnDeactivate += OnDeactivated;
        Interactable.OnMouseOverlap += OnMouseHover;
        Interactable.OnMouseEndOverlap += OnMouseEndHover;
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

    private void OnMouseHover()
    {
        if (!computerRenderer) return;
        
        var color = computerRenderer.color;
        color.a = 1;
        computerRenderer.color = color;
    }

    private void OnMouseEndHover()
    {
        if (!computerRenderer) return;
        
        var color = computerRenderer.color;
        color.a = 0.2f;
        computerRenderer.color = color;
    }

    void OnDestroy()
    {
        Interactable.OnActivate -= OnInteracted;
        Interactable.OnDeactivate -= OnDeactivated;
        Interactable.OnMouseOverlap -= OnMouseHover;
        Interactable.OnMouseEndOverlap -= OnMouseEndHover;
    }
}
