using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics.Contracts;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;

public class PlayerController : MonoBehaviour

{
    public Animator animator;
    public float moveSpeed;
    float speedX, speedY;
    Rigidbody2D rb;
    public CoinManager cm;
    public AudioClip collect;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }

    void Update()
    {
        speedX = Input.GetAxisRaw("Horizontal") * moveSpeed;
        speedY = Input.GetAxisRaw("Vertical") * moveSpeed;
        rb.velocity = new Vector2(speedX, speedY);

        animator.SetFloat("Speed", Mathf.Abs(speedX));

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            AudioSource.PlayClipAtPoint(collect, transform.position);
            Destroy(other.gameObject);
            cm.coinCount++;
        }
    }

}