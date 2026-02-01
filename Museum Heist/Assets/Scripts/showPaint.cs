using UnityEngine;

[RequireComponent(typeof(GameObject))]
public class showPaint : MonoBehaviour
{
    public AudioClip ErrorSound;
    public Transform groundCheckPos;
    public Vector2 groundCheckSize = new Vector2(0.5f, 0.05f);
    public LayerMask groundLayer;
    public GameObject MSPaint;

    void Start()
    {
        MSPaint.GetComponent<GameObject>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            // do the thing
            Debug.Log("I have been overlapped UwU");
            MSPaint.SetActive(true);
        }
    }

}