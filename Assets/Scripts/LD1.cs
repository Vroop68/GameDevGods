using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LD1 : MonoBehaviour
{
    //private AudioSource Teleport;

    //public void Start()
    //{
    //    Teleport = GetComponent<AudioSource>();
    //}
    void OnTriggerEnter2D(Collider2D target)
    {

        if (target.tag == "Player")
        {
            //Teleport.Play();
            //new WaitForSeconds(0.3f);
            SceneManager.LoadScene("LD1");
        }

    }
}

