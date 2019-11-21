using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    public Vector2 speed;
    public Rigidbody2D rigidbody2D;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        rigidbody2D.velocity = speed;
    }

    // Update is called once per frame
    void Update()
    {
        rigidbody2D.velocity = speed;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("Ground"))
        {
            Destroy(other.gameObject);
            Destroy(this.gameObject);
        }
        if(other.gameObject.CompareTag("Boss"))
        {
            Destroy(this.gameObject);
            Boss.instance.reduceHealth(10); 
        }
    }
}
