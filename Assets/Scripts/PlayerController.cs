using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public bool gameStarted = false;

    public Animator anim;
    public Rigidbody2D rb;

    public int jumpForce;

    public Transform groundPoint;

    public LayerMask groundLayer;

    public bool grounded;

    public float yVelocity;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    void FixedUpdate()
    {
        grounded = Physics2D.OverlapPoint(groundPoint.position,groundLayer);
    }

    // Update is called once per frame
    void Update()
    {
        if (gameStarted == false && Input.GetKeyDown(KeyCode.Space)) //game start if (checks for space press)
        {
            gameStarted = true;
            anim.SetTrigger("start");
            return;
        }//end of game start if

        if (grounded && Input.GetKeyDown(KeyCode.Space)) //start jump if (checks for space press)
        {
            anim.SetTrigger("jump");
            rb.AddForce(Vector2.up * jumpForce);
        } //end jump if

        anim.SetFloat("yVelocity", rb.velocity.y);
        anim.SetBool("grounded", grounded);
    }
}
