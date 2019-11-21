using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Boss : MonoBehaviour
{
    public static Boss instance;
    public int health = 100;
    public string nextLevel;
    public TextMeshProUGUI bossDisplayHealth;

    // Start is called before the first frame update
    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(health <= 0)
        {
            MenuController.instance.LoadScene(nextLevel);
        }
    }

    public void OnCollisionEnter2D(Collision2D other)
    {
        
    }

    public void reduceHealth(int reducedHealth)
    {
        health -= reducedHealth;
        bossDisplayHealth.text = health.ToString();
    }
}
