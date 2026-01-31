using System;
using UnityEngine;
using TMPro;
using UnityEngine.EventSystems;

public class ScrollUp : MonoBehaviour, IPointerDownHandler
{
    public TMP_Text textField;
    public static Action<int, char> OnClick;
    public PasswordManager passwordManager;
    public int letterIndex = 0;
    
    public void OnPointerDown(PointerEventData eventData)
    {
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
        OnClick.Invoke(letterIndex, newLetter);
    }
}
