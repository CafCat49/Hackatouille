using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PasswordManager : MonoBehaviour
{
    private string password = "LOUVRE";
    public string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
    public Button m_EnterButton, m_ExitButton;
    private char[] inputs =  new char[6];
    private int attempts = 3;
    public TMP_Text AttemptsText;
    public TMP_Text ResultText;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ResultText.text = "";
        m_EnterButton.onClick.AddListener(OnEnter);
        m_ExitButton.onClick.AddListener(OnExit);
        Scroll.OnUpClick += OnUpClicked;
        Scroll.OnDownClick += OnDownClicked;
    }
    
    private void OnUpClicked(int index, char letter)
    {
        inputs[index] = letter;
    }

    private void OnDownClicked(int index, char letter)
    {
        inputs[index] = letter;
    }
    
    void OnDestroy()
    {
        Scroll.OnUpClick  -= OnUpClicked;
        Scroll.OnDownClick -= OnDownClicked;
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
            ResultText.text = "Correct Password!";
            ResultText.color = Color.green;
            StartCoroutine(Win(3));
        }
        else if (attempts > 1)
        {
            ResultText.text = "Wrong Password!";
            ResultText.color = Color.red;
            attempts--;
            AttemptsText.text = "Attempts Left: " + attempts;
        }
        else
        {
            Debug.Log("Incorrect password, no attempts left");
            SceneManager.LoadScene("MainLevel");
        }
    }

    public void OnExit()
    {
        SceneManager.LoadScene("MainLevel");
    }

    private IEnumerator Win(float time)
    {
        yield return new WaitForSeconds(time);
        SceneManager.LoadScene("Victory");
    }
}
