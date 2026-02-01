using UnityEngine;
using System.Collections;

public class BootUpScreen : MonoBehaviour
{
    public GameObject StartupImage;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartupImage.GetComponent<GameObject>();
        StartCoroutine(Startup(5));
    }
    
    
    private IEnumerator Startup(float time)
    {
        yield return new WaitForSeconds(time);
        StartupImage.SetActive(false);
        
    }
}

