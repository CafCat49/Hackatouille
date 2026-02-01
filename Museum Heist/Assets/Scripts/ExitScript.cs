using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ExitScript : MonoBehaviour
{
    public Button m_ExitButton;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        m_ExitButton.onClick.AddListener(OnExitClick);
    }

    private void OnExitClick()
    {
        SceneManager.LoadScene("MainLevel");
    }
}
