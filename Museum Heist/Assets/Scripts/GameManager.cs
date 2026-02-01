using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public TMP_Text timerText;
    private float gameTime = 480f;
    private float timeRemaining;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }
        
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    private void Start()
    {
        timeRemaining = gameTime;
    }

    private void Update()
    {
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
            if (timerText) DisplayTime(timeRemaining);
        }
        else
        {
            SceneManager.LoadScene("Loss");
        }
    }

    private void DisplayTime(float time)
    {
        float minutes = Mathf.FloorToInt(time / 60);
        float seconds = Mathf.FloorToInt(time % 60);
        
        timerText.text = $"{minutes:00}:{seconds:00}";
    }
    
    public void SetTimerText(TMP_Text textComponent)
    {
        timerText = textComponent;
        DisplayTime(timeRemaining);
    }
}
