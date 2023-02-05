using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float jumpForce;
    public float checkRadius = 0.001f;
    public bool isGrounded;
    public Transform groundCheck;
    public LayerMask whatIsGround;
    public Rigidbody2D rb;

    private int jumps = 2;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        // Check if player is grounded
        Collider2D platform = Physics2D.OverlapCircle(groundCheck.position, checkRadius, whatIsGround);
        isGrounded = platform && platform.gameObject.transform.position.y < groundCheck.position.y;
        // Jump when space is pressed and the player is on the ground
        if (Input.GetKeyDown(KeyCode.Space)) {
            if (isGrounded) {
                rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
                resetRotation();
                jumps = 2;
                jumps--;
            } else if (jumps > 0) {
                rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
                resetRotation();
                jumps--;
            }
        }
    }
    void resetRotation() {
        transform.rotation = Quaternion.Euler(0, 0, 0);
        rb.rotation = 0;
    }
}
