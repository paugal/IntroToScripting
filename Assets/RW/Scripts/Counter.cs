using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Counter : MonoBehaviour
{
    public int count;
    void Start()
    {
        count = 0;
    }

    
    void Update()
    {
        Debug.Log(count);
    }
}
