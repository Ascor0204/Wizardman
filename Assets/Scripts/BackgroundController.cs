using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundController : MonoBehaviour
{
    public Transform startPosit;
    public Transform endPosit;

    public int moveVel = 3;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!GameObject.Find("Wizardman").GetComponent<PlayerController>().gameStarted)
        { //start if (pauses move background during idle
            return;
        } //end if

        if (transform.position.x != endPosit.position.x)
        { // start if (moves the background)
            transform.position = Vector3.MoveTowards(transform.position, endPosit.position, Time.deltaTime * moveVel);
        } else
        {
            transform.position = startPosit.position;
        } //end of if/else
        
    }
}
