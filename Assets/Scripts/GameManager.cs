﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public Transform[] spawnPositions;  //platforms
    public Transform endPosition; 

    public Transform endPosit; //background end point

    public Transform[] fireSpawns;
    public Transform fireEnd;
    public Transform purpleEnd;

    public PlayerController player;

    public FireController fire;

    public int currentScore = 0;

    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddScore()
    {
        currentScore++;
    }

    public void RestartGame()
    {
        SceneManager.LoadSceneAsync(0);
    }
}
