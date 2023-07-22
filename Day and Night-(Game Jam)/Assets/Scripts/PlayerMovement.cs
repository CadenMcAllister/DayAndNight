using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public GameObject groundCheck;
    public Rigidbody2D rb;
    private float horizontal;
    private float vertical;
    [SerializeField]
    private LayerMask groundLayer;
    [SerializeField]
    private BoxCollider2D coll;
    public float speed;
    [SerializeField]
    private float jumpingPower = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    //uses a raycast to determine if the player has terrain of the ground layer below themselves
    private bool IsGrounded()
    {
        return Physics2D.BoxCast(coll.bounds.center, coll.bounds.size, 0f, Vector2.down, .1f, groundLayer);
    }

    // Update is called once per frame
    void Update(){
    
    horizontal = Input.GetAxisRaw("Horizontal");

    if (Input.GetButtonDown("Jump") && IsGrounded())
    {
        rb.velocity = new Vector2(rb.velocity.x, jumpingPower);
    }

    if (Input.GetButtonUp("Jump") && rb.velocity.y == 0f)
    {
        rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y * 0.1f);
    }

    rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);

    }
}
