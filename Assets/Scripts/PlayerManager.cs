using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    private Animator animator;
    private Rigidbody2D rigidbody2D;

    private bool facingRight, jumping, canJump;
    private float speed;

    public float speedX;
    public float jumpSpeedY;

    private int animationStateIdle = 1;
    private int animationStateRun = 3;
    private int animationStateJump = 4;
    private int animationStateFall = 5;

    private Transform firePosition;

    public GameObject leftBullet;
    public GameObject rightBullet;

    private bool canDoubleJump = false;
    private bool isDoubleJumping = false;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        rigidbody2D = GetComponent<Rigidbody2D>();
        facingRight = true;
        canJump = true;
        firePosition = transform.Find("firePosition");
    }

    // Update is called once per frame
    void Update()
    {
        // Mmoving the player
        MovePlayer(speed);

        HandleJumpAndFall();

        // Flipping the player
        Flip();

        // Player moves left
        if(Input.GetKeyDown(KeyCode.LeftArrow))
        {
            speed = -speedX;
        }
        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            speed = 0;
        }

        // Player moves right
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            speed = speedX;
        }
        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            speed = 0;
        }

        // Player jumps
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            if (canJump)
            {
                canJump = false;
                jumping = true;
                rigidbody2D.AddForce(new Vector2(rigidbody2D.velocity.x, jumpSpeedY));
                animator.SetInteger("dino_state", animationStateJump);
            }
            if (canDoubleJump && !isDoubleJumping)
            {
                canJump = true;
                jumping = true;
                isDoubleJumping = true;
            }
        }

        // Fire Bullet
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            FireBullet();
        }
    }

    private void HandleJumpAndFall()
    {
        if (jumping)
        {
            if (rigidbody2D.velocity.y > 0)
            {
                animator.SetInteger("dino_state", animationStateJump);
            }
            else
            {
                animator.SetInteger("dino_state", animationStateFall);
            }
        }
    }

    public void FireBullet()
    {
        if(facingRight)
        {
            Instantiate(rightBullet, firePosition.position, Quaternion.identity);
        }
        if (!facingRight)
        {
            Instantiate(leftBullet, firePosition.position, Quaternion.identity);
        }

    }

    private void MovePlayer(float playerSpeed)
    {
        // Player is idle
        if (playerSpeed == 0 && !jumping)
        {
            animator.SetInteger("dino_state", animationStateIdle);
        }

        // Player is moving eithr right or left
        if (playerSpeed < 0 && !jumping || playerSpeed > 0 && !jumping)
        {
            animator.SetInteger("dino_state", animationStateRun);
        }

        rigidbody2D.velocity = new Vector3(speed, rigidbody2D.velocity.y, 0);
    }
    
    // Flip the player
    private void Flip()
    {
        if (speed > 0 && !facingRight || speed < 0 && facingRight)
        {
            facingRight = !facingRight;
            Vector3 temp = transform.localScale;
            temp.x *= -1;
            transform.localScale = temp;
        }
    }

    public void WalkLeft()
    {
        speed = -speedX;
    }

    public void WalkRight()
    {
        speed = speedX;
    }

    public void StopMoving()
    {
        speed = 0;
    }

    public void Jump()
    {
        if (canJump)
        {
            canJump = false;
            jumping = true;
            rigidbody2D.AddForce(new Vector2(rigidbody2D.velocity.x, jumpSpeedY));
            animator.SetInteger("dino_state", animationStateJump);
        }
        if (canDoubleJump && !isDoubleJumping)
        {
            canJump = true;
            jumping = true;
            isDoubleJumping = true;
        }
    }

    // Every object that uses a rigidBody2D has this method
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Ground")
        {
            canJump = true;
            jumping = false;
            isDoubleJumping = false;
            animator.SetInteger("dino_state", animationStateIdle);
        }

        if(other.gameObject.CompareTag("power_double"))
        {
            canDoubleJump = true;
        }
    }

}
