using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(GameObject))]
public class ShutdownScreen : MonoBehaviour
{
    public GameObject shutdownWindow;

    void Start()
    {
        shutdownWindow.GetComponent<GameObject>();
    }
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // do the thing
            Debug.Log("I have been overlapped UwU");
            shutdownWindow.SetActive(true);
            StartCoroutine(Shutdown(3));
        }
    }

    private IEnumerator Shutdown(float time)
    {
        yield return new WaitForSeconds(time);
        SceneManager.LoadScene("MainLevel");
    }
}