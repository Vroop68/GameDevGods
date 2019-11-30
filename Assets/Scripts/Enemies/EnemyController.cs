using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyController : MonoBehaviour
{
    public float moveSpeed;
    public float timeBetweenMovements;
    public float timeToMove;
    public float waitReload;
    private Rigidbody2D myRigidBody;
    private bool moving;
    private Vector3 moveDirection;
    private float timeBetweenMoveCounter;
    private float timeToMoveCounter;
    private AudioSource Death;


    // Use this for initialization
    void Start()
    {
        myRigidBody = GetComponent<Rigidbody2D>();
        timeBetweenMoveCounter = Random.Range(timeBetweenMovements * 0.75f, timeBetweenMovements * 1.25f);
        timeToMoveCounter = Random.Range(timeToMove * .75f, timeBetweenMovements * 1.25f);
        Death = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

        //Creates randomness within for where it goes and when it moves. 
        if (moving)
        {
            timeToMoveCounter -= Time.deltaTime;
            myRigidBody.velocity = moveDirection;
            if (timeToMoveCounter < 0f)
            {
                moving = false;
                timeBetweenMoveCounter = Random.Range(timeBetweenMovements * 0.75f, timeBetweenMovements * 1.25f);
            }
        }
        else
        {
            timeBetweenMoveCounter -= Time.deltaTime;
            myRigidBody.velocity = Vector2.zero;

            if (timeBetweenMoveCounter < 0f)
            {
                moving = true;
                timeToMoveCounter = Random.Range(timeToMove * 0.75f, timeBetweenMovements * 1.25f);

                moveDirection = new Vector3(Random.Range(-1f, 1f) * moveSpeed, (0f) * moveSpeed, 0f);
            }
        }
    }

    //Checks if bullet collided with enemy
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            Death.Play();
            Destroy(gameObject, 0.4f);
        }
    }

}
