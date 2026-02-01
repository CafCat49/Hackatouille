using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    public Button m_StartButton, m_CreditsButton, m_ExitButton;
    public string LevelName = "";

    private void Start()
    {
        m_StartButton.onClick.AddListener(StartButtonPressed);
        m_CreditsButton.onClick.AddListener(CreditsButtonPressed);
        m_ExitButton.onClick.AddListener(ExitButtonPressed);
    }

    void StartButtonPressed()
    {
        Debug.Log("Starting Game");
        SceneManager.LoadScene(LevelName);
    }

    void CreditsButtonPressed()
    {
        Debug.Log("Showing Credits");
        SceneManager.LoadScene("CreditsScreen");
    }
    
    void ExitButtonPressed()
    {
        Debug.Log("Exiting Game");
        Application.Quit();
    }
}
