using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class DestroySheep : MonoBehaviour
{
    Vector3 pos1 = new Vector3(0.21f, 0, 55.56f);
    Vector3 pos2 = new Vector3(-16.1f, 0, 55.56f);
    Vector3 pos3 = new Vector3(16.1f, 0, 55.56f);

    public TextMeshProUGUI gameover;
    public GameObject sheep;
    public float thresholdGenerator = 1;
    float measureTime = 0;
    public int health;
    public Slider healthBar;
    public float damage;

    private Quaternion rotation = new Quaternion();

    void Start()
    {
        healthBar.SetValueWithoutNotify(1);
        measureTime = Time.time;
        health = 10;
        gameover.enabled = false;
        rotation[1] = 190;
        rotation[2] = 180;
        rotation[3] = 0;

    }

    
    void Update()
    {
        float ranPos = Random.Range(0f, 90f);
        if ((Time.time - measureTime) > thresholdGenerator)
        {
            if(ranPos < 30)
            {
                Instantiate(sheep, pos1, rotation);
            }else if(ranPos > 30 && ranPos < 60)
            {
                Instantiate(sheep, pos2, rotation);
            }else
                Instantiate(sheep, pos3, rotation);

            measureTime = Time.time;
        }

        if(healthBar.value <= 0)
            gameover.enabled = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
        healthBar.value = healthBar.value - 0.1f;

        
        Debug.Log(health);
    }
}
