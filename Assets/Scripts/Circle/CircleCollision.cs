using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleCollision : MonoBehaviour
{
    AudioSource audioSource;
    Renderer renderer;
    CircleCollider2D circleCollider;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        print(gameObject.name + "OnCollisionEnter2D with " + collision.gameObject.name);

        // This function creates an audio source but automatically disposes of it once the clip has finished playing.
        //AudioSource.PlayClipAtPoint(audioSource.clip, Vector3.forward);

        #region Disable object first then destroy it after finish play audio
        // Get object renderer and collider and disable it
        renderer = GetComponent<Renderer>();
        renderer.enabled = false;
        circleCollider= GetComponent<CircleCollider2D>();
        circleCollider.enabled = false;
        audioSource.Play();
        #endregion

        // Delayed destroy to be able to hear the audio
        Destroy(this.gameObject, audioSource.clip.length);


        //Destroy(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
