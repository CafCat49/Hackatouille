using System;
using UnityEngine;


[RequireComponent(typeof(AudioSource))]
public class PlaySoundOnOverlap : MonoBehaviour
{
    public AudioClip ErrorSound;
    private AudioSource audioSource;
    public Transform groundCheckPos;
    public Vector2 groundCheckSize = new Vector2(0.5f, 0.05f);
    public LayerMask groundLayer;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            // do the thing
            Debug.Log("I have been overlapped UwU");
            audioSource.PlayOneShot(ErrorSound);
        }
    }
   
    private void onDrawGizmosSelected()
    {
        Gizmos.color = Color.white;
        Gizmos.DrawWireCube(groundCheckPos.position, groundCheckSize);
    }
}
