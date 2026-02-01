using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager Instance;
    public TMP_Text timerText;
    public float gameTime = 0f;

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

    private void Update()
    {
        gameTime += Time.deltaTime;

        if (timerText) DisplayTime(gameTime);
    }

    private void DisplayTime(float time)
    {
        float minutes = Mathf.FloorToInt(time / 60);
        float seconds = Mathf.FloorToInt(time % 60);
        
        timerText.text = $"{minutes:00}:{seconds:00}";
    }
}
