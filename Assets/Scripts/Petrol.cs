using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Petrol : MonoBehaviour
{
    public float speed;
    private bool movingRight = true;
    public Transform groundDetection;

    public void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);
        RaycastHit2D groundInfo = Physics2D.Raycast(groundDetection.position, Vector2.down, 0.5f);

        if(groundInfo.collider == false)
        {
            if (movingRight == true)
            {
                transform.eulerAngles = new Vector3(0, -180, 0);
                movingRight = false;
            } else
            {
                transform.eulerAngles = new Vector3(0, 0, 0);
                movingRight = true;
            }
        }
    }

    public void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            HealthManager.instance.reduceHeealth(25);
            Destroy(this.gameObject);
        }
    }
}
