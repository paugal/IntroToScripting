﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SheepMove : MonoBehaviour
{
    public float speed = 2;  
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.back * speed, Space.World);
    }

    private void OnTriggerEnter(Collider other)
    {
        
        if(other.tag != "limit")
        Destroy(other.gameObject);
        Destroy(this.gameObject);
    }
}
