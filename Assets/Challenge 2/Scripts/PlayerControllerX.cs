﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    private float endTimer = 0;
    public GameObject dogPrefab;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log(endTimer);

            if (endTimer <= 0)
            {
                Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
                endTimer = 0.7f;
            }


        }
        endTimer -= Time.deltaTime;
    }
    
}