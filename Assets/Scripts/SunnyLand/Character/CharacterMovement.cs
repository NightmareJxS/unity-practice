using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    [SerializeField]
    public float movementSpeed;
    [SerializeField]
    public float jumpForce;

    public bool isGrounded = false;

    private int score = 0;
    private float _horizontalInput;
    private float _verticalInput;
    private Vector2 _movementInput;
    private Rigidbody2D _rb;
    private bool _jumpInput;

    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // Get user input with no smoothing
        _horizontalInput = Input.GetAxisRaw("Horizontal");
        _verticalInput = Input.GetAxisRaw("Vertical");// No need for vertical input
        _jumpInput = Input.GetKeyDown(KeyCode.Space);

        jump();
    }

    private void FixedUpdate()
    {
        Move();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name.Contains("Cherry"))
        {
            score += 1;
            Destroy(collision.gameObject);
            print(score);
        }

        if (collision.gameObject.name.Contains("Gem"))
        {
            score += 5;
            Destroy(collision.gameObject);
            print(score);
        }
    }

    private void Move()
    {
        // Moving left and right
        if (_horizontalInput > 0.1f || _horizontalInput < -0.1f)
        {
            _rb.AddForce(new Vector2(_horizontalInput * movementSpeed, 0f), ForceMode2D.Impulse);
        }
    }

    private void jump()
    {
        // Jumping
        if (_jumpInput && isGrounded)
        {
            _rb.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
        }
    }
}
