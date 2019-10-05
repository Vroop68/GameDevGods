using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
// public class Boundary
// {
//     public float minX, maxX, minY, maxY;
// }

public class PlayerController : MonoBehaviour
{

    // Public variables
    public float speed = 5.0f;
    public float attackTime;


    // Private variables
    private Vector2 lastDir;
    [SerializeField]
    private Vector2 movement;

    private Rigidbody2D rBody;
    private float myTime = 0.0f;
    private Animator anim;
    private bool isMoving;
    private BoxCollider2D boxCollider;
    private bool IsAttacking;
    private float attackTimeCounter;


    void Awake()
    {
        anim = GetComponent<Animator>();
        rBody = GetComponent<Rigidbody2D>();
        boxCollider = GetComponent<BoxCollider2D>();
    }

    void Start()
    {

    }

    void Update()
    {
        myTime += Time.deltaTime;


        // if (Input.GetKeyDown(KeyCode.Space))
        // {
        //     attackTimeCounter = attackTime;
        //     IsAttacking = true;
        //     anim.SetBool("IsAttacking", true);
        // }
        // if (attackTimeCounter > 0)
        // {
        //     attackTimeCounter -= Time.deltaTime;
        // }
        // if (attackTimeCounter <= 0)
        // {
        //     IsAttacking = false;
        //     anim.SetBool("IsAttacking", false);
        // }
    }
    void FixedUpdate()
    {
        CheckInput();
    }

    void CheckInput()
    {
        if (!IsAttacking)
        {


            isMoving = false;

            float moveHorizontal = Input.GetAxisRaw("Horizontal");



            if (moveHorizontal < 0 || moveHorizontal > 0)
            {
                isMoving = true;

                if (!boxCollider.IsTouchingLayers(Physics2D.AllLayers))
                    lastDir = rBody.velocity;
            }
            movement = new Vector2(moveHorizontal, 0f);

            CalcMovement(movement * speed);
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

    void CalcMovement(Vector2 PlayerForce)
    {
        rBody.velocity = Vector2.zero;
        rBody.AddForce(PlayerForce, ForceMode2D.Impulse);

        //SendAnimInfo();
    }

    // void SendAnimInfo()
    // {
    //     anim.SetFloat("LastX", lastDir.x);
    //     anim.SetFloat("LastY", lastDir.y);
    //     anim.SetFloat("XSpeed", rBody.velocity.x);
    //     anim.SetFloat("YSpeed", rBody.velocity.y);


    //     anim.SetBool("IsMoving", isMoving);


    // }
}
