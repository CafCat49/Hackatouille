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
    }

    void StartButtonPressed()
    {
        Debug.Log("Starting Game");
        SceneManager.LoadScene(LevelName);
    }
}
