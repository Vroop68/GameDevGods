using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoryPage : MonoBehaviour
{
    public GameObject story;


    // Start is called before the first frame update
    void Start()
    {
        story.gameObject.SetActive(false);
    }
    
    //Checks if player collided with page from book.
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            story.gameObject.SetActive(true);
            Destroy(story.gameObject, 10f);
        }
    }
}
