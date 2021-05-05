using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HayMachineControl : MonoBehaviour
{
    public float inputKeyValue;
    public float moveAmount = 0.5f;
    public AudioSource audioshoot;

    public GameObject hayShootObject;
    public float thresholdShoot = 0.5f;
    float measureTime = 0;


    void Start()
    {
        measureTime = Time.time;
    }
  
   
    
    void Update()
    {
        Move();
        Shoot();
    }

    void Shoot()
    {
        if (Input.GetKey(KeyCode.Space) && (Time.time - measureTime) > thresholdShoot)
        {
            audioshoot.Play();
            Vector3 haypos = transform.position;
            haypos.y = 1;
            Instantiate(hayShootObject, haypos, Quaternion.identity);
            measureTime = Time.time;
        }
    }

    void Move()
    {
        inputKeyValue = Input.GetAxis("Horizontal");
        Vector3 newPos = transform.position + Vector3.right * moveAmount * inputKeyValue;

        if (newPos.x > -20 && newPos.x < 20)
        {
            transform.Translate(Vector3.right * moveAmount * inputKeyValue);
        }
    }
}
