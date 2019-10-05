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
    // private bool reloading;
    //private GameObject thePlayer;

    // Use this for initialization
    void Start()
    {
        myRigidBody = GetComponent<Rigidbody2D>();

        //timeBetweenMoveCounter = timeBetweenMovements;
        //timeToMoveCounter = timeToMove;


        timeBetweenMoveCounter = Random.Range(timeBetweenMovements * 0.75f, timeBetweenMovements * 1.25f);
        timeToMoveCounter = Random.Range(timeToMove * .75f, timeBetweenMovements * 1.25f);

    }


    // Update is called once per frame
    void Update()
    {



        if (moving)
        {
            timeToMoveCounter -= Time.deltaTime;
            myRigidBody.velocity = moveDirection;
            if (timeToMoveCounter < 0f)
            {
                moving = false;
                //timeBetweenMoveCounter = timeBetweenMovements;
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
                //timeToMoveCounter = timeToMove;
                timeToMoveCounter = Random.Range(timeToMove * 0.75f, timeBetweenMovements * 1.25f);

                moveDirection = new Vector3(Random.Range(-1f, 1f) * moveSpeed, (0f) * moveSpeed, 0f);
            }
        }

        /**  if (reloading)
          {
              waitReload -= Time.deltaTime;
              if (waitReload < 0)
              {
                  SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
                  thePlayer.SetActive(true);
              }
          }*/

    }

}
