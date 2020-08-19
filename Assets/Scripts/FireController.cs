using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireController : MonoBehaviour
{

    public GameObject green;
    public GameObject purple;

    public Transform greenfire;
    public Transform purplefire;

    public bool appeared = false;

    public float countdown = 5;

    Transform fireStart;

    public int vel = 8;
    bool purpleCreated = false;


    // Update is called once per frame
    void Update()
    {
        if (!GameObject.Find("Wizardman").GetComponent<PlayerController>().gameStarted)
        { //start if (pauses movement during idle)
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
        }

        if (greenfire.position.x != GameManager.instance.fireEnd.position.x)
        {
            greenfire.position = Vector3.MoveTowards(greenfire.position, new Vector3(GameManager.instance.fireEnd.position.x, greenfire.position.y, greenfire.position.z), Time.deltaTime * vel);
        }
        else
        {
            fireStart = GameManager.instance.fireSpawns[Random.Range(0, GameManager.instance.fireSpawns.Length)];
            greenfire.position = fireStart.position;
        }

        if (purpleCreated && purplefire.position.x < GameManager.instance.purpleEnd.position.x)
        {
            purplefire.position = Vector3.MoveTowards(purplefire.position, new Vector3(GameManager.instance.purpleEnd.position.x, purplefire.position.y, purplefire.position.z), Time.deltaTime * vel);
        } else
        {
            purple.SetActive(false);
        }
    }

    public void CreateFireball()
    {
        purple.SetActive(true);
        purpleCreated = true;
        purplefire.position = GameManager.instance.player.transform.position;

    }
}
