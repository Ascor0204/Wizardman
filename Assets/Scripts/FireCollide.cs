using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireCollide : MonoBehaviour
{

    public GameObject greenfire;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            GameManager.instance.player.GameOver();
            greenfire.SetActive(false);
        }
    }
}