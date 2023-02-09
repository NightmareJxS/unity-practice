using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bouncing : MonoBehaviour
{

    Rigidbody2D rb;
    Vector3 randomVector;

    // Start is called before the first frame update
    void Start()
    {
        randomVector = new Vector3(Random.Range(-5f, 5f), Random.Range(-5f, 5f), 0);
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void FixedUpdate()
    {
        rb.AddForce(randomVector * 10f);


        Vector3 pos = Camera.main.WorldToViewportPoint(transform.position);

        if (pos.x < 0.0)
        {
            Debug.Log("I am left of the camera's view.");

            randomVector = Vector3.Reflect(randomVector, Vector3.right);
            rb.velocity = Vector3.Reflect(rb.velocity, Vector3.right);
        }

        if (1.0 < pos.x)
        {

            Debug.Log("I am right of the camera's view.");
            randomVector = Vector3.Reflect(randomVector, Vector3.left);
            rb.velocity = Vector3.Reflect(rb.velocity, Vector3.left);
        }

        if (pos.y < 0.0)
        {
            Debug.Log("I am below the camera's view.");
            randomVector = Vector3.Reflect(randomVector, Vector3.down);
            rb.velocity = Vector3.Reflect(rb.velocity, Vector3.down);
        }

        if (1.0 < pos.y)
        {
            Debug.Log("I am above the camera's view.");
            randomVector = Vector3.Reflect(randomVector, Vector3.up);
            rb.velocity = Vector3.Reflect(rb.velocity, Vector3.up);
        }
    }
}
