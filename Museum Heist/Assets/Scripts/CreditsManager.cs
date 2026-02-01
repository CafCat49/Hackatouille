using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CreditsManager : MonoBehaviour
{
    public Button m_ReturnButton;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        m_ReturnButton.onClick.AddListener(OnReturnClick);
    }

    private void OnReturnClick()
    {
        SceneManager.LoadScene("TitleMenu");
    }
}
