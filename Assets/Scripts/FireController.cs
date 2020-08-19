using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireController : MonoBehaviour
{

    public GameObject green;
    public GameObject purple;

    bool appeared = false;

    public float countdown = 5;

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

        if (!appeared)
        {
            countdown -= Time.deltaTime;
        }

        if (countdown < 0)
        {
            appeared = true;
            green.SetActive(true);
            purple.SetActive(true);
        }


    }
}
