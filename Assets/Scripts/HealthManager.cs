using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using TMPro;

public class HealthManager : MonoBehaviour
{
    public static HealthManager instance;
    public int health = 100;
    //public TextMeshProUGUI healthAmount;

    // Start is called before the first frame update
    void Start()
    {
        if(instance == null)
        {
            instance = this;
        }
    }

    public void Update()
    {
        if(health <= 0)
        {
            MenuController.instance.LoadScene("01.Menu");
        }
    }

    public void reduceHeealth(int damageTaken)
    {
        this.health = health - damageTaken;
        //this.healthAmount.text = this.health.ToString();
    }

}
