using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LD2 : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D target)
    {

        if (target.tag == "Player")
        {
            SceneManager.LoadScene("LD2");

            //Teleport sound to be added here.
            //explosionSound.Play();
            //anim.Play("Destroy");

        }

    }
}