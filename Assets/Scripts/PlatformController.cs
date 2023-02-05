using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformController : MonoBehaviour
{
    public float width = 4.0f;
    public Rigidbody2D rb;
    public BoxCollider2D bc;
    
    // Start is called before the first frame update
    void Start()
    {
        bc.size = new Vector2(width, bc.size.y);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
