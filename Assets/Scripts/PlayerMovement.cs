using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Util;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rBody;
    public PlayerAnimState playerAnimState;
    public Animator playerAnimator;

    [Header("Player Properties")]
    public float jumpHeight;
    public float speed;

    public bool isGrounded;


    public void Start()
    {
        rBody = gameObject.GetComponent<Rigidbody2D>();
        playerAnimState = PlayerAnimState.IDLE;
    }

    // Update is called once per frame
    public void Update()
    {
        //Call moving function
        Movement();

        //Flip the character
        Vector3 characterScale = transform.localScale;
        if (Input.GetAxis("Horizontal") < 0)
        {
            characterScale.x = -13;
            playerAnimState = PlayerAnimState.WALK;
            playerAnimator.SetInteger("AnimState", (int)PlayerAnimState.WALK);
        }
        if (Input.GetAxis("Horizontal") > 0)
        {
            characterScale.x = 13;
            playerAnimState = PlayerAnimState.WALK;
            playerAnimator.SetInteger("AnimState", (int)PlayerAnimState.WALK);
        }
        transform.localScale = characterScale;

        //Return to idle
        if (Input.GetAxis("Horizontal") == 0)
        {
            playerAnimState = PlayerAnimState.IDLE;
            playerAnimator.SetInteger("AnimState", (int)PlayerAnimState.IDLE);
        }
    }

    //Basic movement function
    void Movement()
    {
        //X-Axis movement
        float moveHorizontal = Input.GetAxis("Horizontal");
        rBody.velocity = new Vector2(moveHorizontal * speed, rBody.velocity.y);

        //Y-Axis/Jumping movement
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded == true)
        {
            rBody.AddForce(new Vector3(0.0f, jumpHeight, 0.0f), ForceMode2D.Impulse);
            isGrounded = false;
        }
    }

    //checks if player is in grounded state to allow jumping
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            isGrounded = true;
        }
    }
}