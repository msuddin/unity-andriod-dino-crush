using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SignPostNextLevel : MonoBehaviour
{
    public string nextLevel;

    public void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            MenuController.instance.LoadScene(nextLevel);
        }
    }
}
