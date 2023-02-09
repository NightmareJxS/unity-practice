using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField]
    float speed = 1000f;

    Rigidbody2D rb;
    Vector2 moving;


    // Start is called before the first frame update
    void Start()
    {
        rb= GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        moving = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
    }

    void MoveObject(Vector2 direction)
    {
        rb.AddForce(direction * speed);
    }

    void FixedUpdate()
    {
        MoveObject(moving);
    }
}
