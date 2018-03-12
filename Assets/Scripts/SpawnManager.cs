﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour {

    public int maxPlatforms = 18;
    public GameObject platform;
    public float horizontalMin = 6f;
    public float horizontalMax = 15f;
    public float verticalMin = -6f;
    public float verticalMax = 6f;

    private Vector2 originPosition;


    void Start()
    {

        originPosition = transform.position;
        Spawn();

    }


    void Spawn()
    {
        for (int i = 0; i < maxPlatforms; i++)
        {
            Vector2 randomPosition = originPosition + new Vector2(Random.Range(horizontalMin, horizontalMax), Random.Range(verticalMin, verticalMax));
            Instantiate(platform, randomPosition, Quaternion.identity);
            originPosition = randomPosition;

        }
        

        
    }

}