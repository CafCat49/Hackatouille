using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(GameObject))]
public class shutdownScreen : MonoBehaviour
{
    public AudioClip ErrorSound;
    public Transform groundCheckPos;
    public Vector2 groundCheckSize = new Vector2(0.5f, 0.05f);
    public LayerMask groundLayer;
    public GameObject shutdownWindow;

    void Start()
    {
        shutdownWindow.GetComponent<GameObject>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            // do the thing
            Debug.Log("I have been overlapped UwU");
            shutdownWindow.SetActive(true);
            SceneManager.LoadScene("PasswordScramble");
        }
    }

}