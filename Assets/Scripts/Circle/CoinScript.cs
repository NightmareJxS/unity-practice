using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour
{
    private Rigidbody2D rb;
    public bool checkBottom;

    // Start is called before the first frame update
    void Start()
    {
        rb= GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float moveY = 0f;
        if (checkBottom)
        {
            moveY = -5f;
        }
        else
        {
            moveY = 5f;
        }

        rb.velocity = new Vector2(0, transform.localScale.y)* moveY;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Bottom")
        {
            checkBottom = false;
        }
        if (collision.gameObject.name == "Top")
        {
            checkBottom = true;
        }
        
    }
}
