using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireCollide : MonoBehaviour
{

    
    public Transform playerPosit;
    public Transform firePosit;

    public GameObject fire;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            GameManager.instance.player.GameOver();
            fire.SetActive(false);
        }

    }
}