using UnityEngine;

/*public class ShowPassword : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
*/
[RequireComponent(typeof(GameObject))]
public class showPassword : MonoBehaviour
{
    public AudioClip ErrorSound;
    public Transform groundCheckPos;
    public Vector2 groundCheckSize = new Vector2(0.5f, 0.05f);
    public LayerMask groundLayer;
    public GameObject passwordWindow;

    void Start()
    {
        passwordWindow.GetComponent<GameObject>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            // do the thing
            Debug.Log("I have been overlapped UwU");
            passwordWindow.SetActive(true);
        }
    }

}