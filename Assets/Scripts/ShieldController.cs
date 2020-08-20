using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldController : MonoBehaviour
{

    public GameObject Shield;
    public float shieldDuration;
    bool shieldAppeared = false;


    // Update is called once per frame
    void Update()
    {
        if (shieldAppeared)
        {
            shieldDuration -= Time.deltaTime;
            transform.position = GameManager.instance.player.transform.position;
            transform.position = new Vector3(transform.position.x + 1.75f, transform.position.y + 2.58f, transform.position.z);
        }
        if (shieldDuration < 0)
        {
            shieldAppeared = false;
            gameObject.SetActive(false);
        }
    }

    public void CreateShield()
    {
        gameObject.SetActive(true);
        shieldDuration = 3;
        shieldAppeared = true;
        
            
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("green"))
        {
            GameManager.instance.currentScore -= 1;
            GameObject.Find("Fires").GetComponent<FireController>().appeared = false;
            GameObject.Find("Fires").GetComponent<FireController>().countdown = 3;
            GameManager.instance.green.SetActive(false);
            gameObject.SetActive(false);
            shieldDuration = -1;
        }
    }

}
