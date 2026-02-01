using System;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Scroll : MonoBehaviour
{
    public TMP_Text textField;
    public static Action<int, char> OnUpClick;
    public static Action<int, char> OnDownClick;
    public PasswordManager passwordManager;
    public int letterIndex;
    public Button m_ScrollUpButton, m_ScrollDownButton;

    void Start()
    {
        m_ScrollUpButton.onClick.AddListener(ScrollUp);
        m_ScrollDownButton.onClick.AddListener(ScrollDown);
    }

    public void ScrollUp()
    {
        if (!passwordManager) return;
        if (!textField) return;
        
        char currentLetter = textField.text[0];
        int currentIndex = passwordManager.alphabet.IndexOf(currentLetter);
        char newLetter;
        if (currentIndex < 25)
        {
            newLetter = passwordManager.alphabet[currentIndex + 1];
        }
        else
        {
            newLetter = passwordManager.alphabet[0];
        }
        textField.text = newLetter.ToString();
        OnUpClick.Invoke(letterIndex, newLetter);
    }

    public void ScrollDown()
    {
        if (!passwordManager) return;
        if (!textField) return;
        
        char currentLetter = textField.text[0];
        int currentIndex = passwordManager.alphabet.IndexOf(currentLetter);
        char newLetter;
        if (currentIndex > 0)
        {
            newLetter = passwordManager.alphabet[currentIndex - 1];
        }
        else
        {
            newLetter = passwordManager.alphabet[25];
        }
        textField.text = newLetter.ToString();
        OnDownClick.Invoke(letterIndex, newLetter);
    }
}
