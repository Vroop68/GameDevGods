using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb2d;

    [Header("Player Properties")]
    public float jumpHeight;
    public float speed;

    public bool isGrounded;


    public void Start()
    {
        rb2d = gameObject.GetComponent<Rigidbody2D>();
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
            characterScale.x = -1;
        }
        if (Input.GetAxis("Horizontal") > 0)
        {
            characterScale.x = 1;
        }
        transform.localScale = characterScale;
    }

    //Basic movement function
    void Movement()
    {
        //X-Axis movement
        float inputX = Input.GetAxis("Horizontal");
        rb2d.velocity = new Vector2(inputX * speed, rb2d.velocity.y);

        //Y-Axis/Jumping movement
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded == true)
        {
            rb2d.AddForce(new Vector3(0.0f, jumpHeight, 0.0f), ForceMode2D.Impulse);
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