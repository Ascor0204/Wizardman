using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Animator anim;
    public Rigidbody2D rb;

    public int jumpForce;

    bool gameStarted = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && gameStarted == false) //game start if (checks for space press)
        {
            gameStarted = true;
            anim.SetTrigger("start");
            return;
        }//end of game start if

        if (Input.GetKeyDown(KeyCode.Space)) //start jump if (checks for space press)
        {
            anim.SetTrigger("jump");
            rb.AddForce(Vector2.up * jumpForce);
        } //end jump if
    }
}
