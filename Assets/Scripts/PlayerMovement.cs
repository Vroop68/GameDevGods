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
    private AudioSource Ow;
    private AudioSource Jump;
    public bool isGrounded;
    bool facingRight = true;
    public GameObject bulletToRight, bulletToLeft;
    Vector2 bulletPos;
    public float fireRate = 0.7f;
    float nextFire = 0.0f;

    public void Start()
    {
        rBody = gameObject.GetComponent<Rigidbody2D>();
        playerAnimState = PlayerAnimState.IDLE;
        Ow = GetComponent<AudioSource>();
        Jump = GetComponent<AudioSource>();
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
            facingRight = false;
            characterScale.x = -13;
            playerAnimState = PlayerAnimState.WALK;
            playerAnimator.SetInteger("AnimState", (int)PlayerAnimState.WALK);
        }
        if (Input.GetAxis("Horizontal") > 0)
        {
            facingRight = true;
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
        //Shoot projectile
        if (Input.GetButtonDown("Fire1") && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            fire();
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
            Jump.Play();
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

        if (collision.gameObject.tag == "enemy")
        {
          Ow.Play();
        }

        //if (collision.gameObject.tag == "Page")
        //{
        //    Destroy(gameObject);
        //}
    }

    void fire()
    {
        bulletPos = transform.position;
        if (facingRight)
        {
            bulletPos += new Vector2(+3f, -0.23f);
            Instantiate(bulletToRight, bulletPos, Quaternion.identity);
        }
        else
        {
            bulletPos += new Vector2(-3f, -0.23f);
            Instantiate(bulletToLeft, bulletPos, Quaternion.identity);
        }
    }
}