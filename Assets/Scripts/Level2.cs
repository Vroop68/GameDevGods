using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level2 : MonoBehaviour
{
<<<<<<< HEAD
=======
    //private AudioSource Teleport;

    //public void Start()
    //{
    //    Teleport = GetComponent<AudioSource>();
    //}
>>>>>>> master
    void OnTriggerEnter2D(Collider2D target)
    {

        if (target.tag == "Player")
        {
<<<<<<< HEAD
            SceneManager.LoadScene("Level_2");

            //Teleport sound to be added here.
            //explosionSound.Play();
            //anim.Play("Destroy");

=======
            //Teleport.Play();
            //new WaitForSeconds(0.3f);
            SceneManager.LoadScene("Level_2");
>>>>>>> master
        }

    }
}
