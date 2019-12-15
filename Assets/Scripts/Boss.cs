using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using TMPro;

public class Boss : MonoBehaviour
{
    public static Boss instance;
    public int health = 100;
    public int defence = 5;

    //public TextMeshProUGUI bossDisplayHealth;

    // Start is called before the first frame update
    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    public void reduceHealth(int reducedHealth)
    {
        health -= reducedHealth;
        //bossDisplayHealth.text = health.ToString();
    }

    public int getCurrentHealth()
    {
        return this.health;
    }

    public void setDefence(int newDefence)
    {
        this.defence = newDefence;
    }

    public int getDefence()
    {
        return this.defence;
    }

    public void Update()
    {
        if (health <= 0)
        {
            MenuController.instance.LoadScene("01.Menu");
        }
    }
}
