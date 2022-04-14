using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceshipPlayer : MonoBehaviour
{
    public float speed = 10;
    public AudioClip destroySound;
    public Sprite destroyedFire;

    private AudioSource audioSource;
    private SpriteRenderer spriteRenderer;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        Movement();
    }

    void Movement()
    {
        // apply forward input
        Vector3 movement = Input.GetAxis("Horizontal") * new Vector3(1,0,0) * speed;

        transform.position += movement * Time.deltaTime;

        //  GetComponent<Rigidbody2D>().position += velocity * Time.deltaTime;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.gameObject.name);
        audioSource.clip = destroySound;
        audioSource.Play();
        spriteRenderer.sprite = destroyedFire;
        Destroy(this.gameObject, 2.0f);
    }
}
