using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class UserMovement : MonoBehaviour
{
    Rigidbody2D rb;
    private float moveSpeed = 2000f;
    private int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        rb= GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity= Vector2.zero;
        if (Input.GetKey(KeyCode.DownArrow))
        {
            rb.velocity = new Vector2(0, -moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.velocity = new Vector2(moveSpeed * Time.deltaTime, 0);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rb.velocity = new Vector2(0, moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.velocity = new Vector2(-moveSpeed * Time.deltaTime, 0);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Mushroom")
        {
            score += 1;
            Destroy(collision.gameObject);
            print(score);
        }
        if (collision.gameObject.name == "Coin")
        {
            score -= 1;
            Destroy(gameObject);
        }
    }
}
