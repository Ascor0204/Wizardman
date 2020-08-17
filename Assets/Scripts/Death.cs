using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour
{
    public PlayerController player;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //if something enters, it must be player
        //stop the camera and kill the player
        player.gameOver();
    }
}
