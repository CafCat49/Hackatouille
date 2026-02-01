using UnityEngine;
using TMPro;

public class TimerDisplay : MonoBehaviour
{
    public TMP_Text timerText;

    void Start()
    {
        if (GameManager.Instance != null)
        {
            GameManager.Instance.SetTimerText(timerText);
        }
        else
        {
            Debug.LogError("GameManager instance not found!");
        }
    }
}