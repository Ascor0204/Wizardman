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

    public GameObject deathEffect;
    public Transform effectPosition;

    public GameObject gameover;

    //body parts
    public GameObject head;
    public GameObject body;
    public GameObject arm1;
    public GameObject arm2;
    public GameObject feet1;
    public GameObject feet2;
    public GameObject feather;



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

    public void GameOver()
    {
        gameStarted = false;
        Instantiate(deathEffect, effectPosition.position, Quaternion.identity);
        gameover.SetActive(true);
        rb.constraints = RigidbodyConstraints2D.FreezeAll;
        head.SetActive(false);
        body.SetActive(false);
        arm1.SetActive(false);
        arm2.SetActive(false);
        feet1.SetActive(false);
        feet2.SetActive(false);
        feather.SetActive(false);
    }
}
