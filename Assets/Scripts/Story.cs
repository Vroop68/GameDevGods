using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Story : MonoBehaviour
{
    public GameObject story;

    // Start is called before the first frame update
    void Start()
    {
        story.gameObject.SetActive(false);
    }

    //Update is called once per frame
    void Update()
    {
        story.gameObject.SetActive(true);
        //Destroy(gameObject, 10f);
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "Player")
        {
            Update();
            story.gameObject.SetActive(true);
            //Destroy(gameObject, 10f);
        }
    }
}
