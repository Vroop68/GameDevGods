using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoryPage : MonoBehaviour
{

    //Checks if player collided with page from book.
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(gameObject, 0.1f);
        }
    }
}
