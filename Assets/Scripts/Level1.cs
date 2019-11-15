using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level1 : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D target)
    {

        if (target.tag == "Player")
        {
            SceneManager.LoadScene("Level1");

            //Teleport sound to be added here.

            // play explosion sound
            //explosionSound.Play();
            //anim.Play("Destroy");

        }

    }

}
