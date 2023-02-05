using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformController : MonoBehaviour
{
    public float width = 4.0f;
    public Rigidbody2D rb;
    public BoxCollider2D bc;
    public LevelController level;
    public float despawnX = -10.0f;

    // Start is called before the first frame update
    void Start()
    {
        transform.localScale = new Vector2(width, transform.localScale.y);
    }

    // Update is called once per frame
    void Update()
    {
        // Delete if off screen
        if (transform.position.x < despawnX - width) {
            Destroy(gameObject);
        }
        // Set speed
        rb.velocity = new Vector2(-level.levelSpeed, rb.velocity.y);
    }
}
