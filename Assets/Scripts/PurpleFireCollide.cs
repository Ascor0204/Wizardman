using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurpleFireCollide : MonoBehaviour
{
    public GameObject purpleFire;
    public GameObject greenFire;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("green"))
        {
            GameManager.instance.AddScore();
            GameObject.Find("Fires").GetComponent<FireController>().appeared = false;
            GameObject.Find("Fires").GetComponent<FireController>().countdown = 3;
            greenFire.SetActive(false);
            purpleFire.SetActive(false);
        }
    }

}
