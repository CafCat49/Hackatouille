using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PasswordManager : MonoBehaviour
{
    private string password = "LOUVRE";
    public string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
    public Button m_EnterButton;
    private char[] inputs =  new char[6];
    private int attempts = 3;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        m_EnterButton.onClick.AddListener(OnEnter);
        ScrollUp.OnClick += OnUpClicked;
        ScrollDown.OnClick += OnDownClicked;
    }

    private void OnUpClicked(int index, char letter)
    {
        inputs[index]  = letter;
    }

    private void OnDownClicked(int index, char letter)
    {
        inputs[index]  = letter;
    }
    
    void OnDestroy()
    {
        ScrollUp.OnClick -= OnUpClicked;
        ScrollDown.OnClick -= OnDownClicked;
    }

    public void OnEnter()
    {
        string finalInput = string.Empty;
        foreach (char c in inputs)
        {
            finalInput += c.ToString();
        }

        if (finalInput == password)
        {
            Debug.Log("Correct password");
            SceneManager.LoadScene("Victory");
        }
        else if (attempts > 0)
        {
            Debug.Log("Incorrect password");
            attempts--;
        }
        else
        {
            Debug.Log("Incorrect password, no attempts left");
            SceneManager.LoadScene("MainLevel");
        }
    }
}
