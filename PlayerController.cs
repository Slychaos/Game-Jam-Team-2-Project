using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    public float moveSpeed;
    public float jumpForce;

    private Rigidbody2D RB2D;

    public bool grounded;
    public LayerMask whatIsGround;

    private Collider2D C2D; 


	void Start ()
    {
        RB2D = GetComponent<Rigidbody2D>();
        C2D = GetComponent<Collider2D>();
            
	}


    void Update()
    {
        grounded = Physics2D.IsTouchingLayers(C2D, whatIsGround);
        RB2D.velocity = new Vector2(moveSpeed, RB2D.velocity.y);
        if (Input.GetKeyDown(KeyCode.Space))
            {
            RB2D.velocity = new Vector2(RB2D.velocity.x, jumpForce);
        }
    }
}
