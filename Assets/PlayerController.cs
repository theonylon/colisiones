﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     if (Input.GetKeyDown(KeyCode.W))
        {
            
                transform.position = new Vector3(-4f, 1.6f, 0);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            
                transform.position = new Vector3(-4f, 0.5f, 0);
           
        }
    }
}
