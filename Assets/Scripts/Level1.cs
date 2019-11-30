using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level1 : MonoBehaviour
{
    private AudioSource Teleport;

    public void Start()
    {
        Teleport = GetComponent<AudioSource>();
    }
    void OnTriggerEnter2D(Collider2D target)
    {

        print("Collision");
        if (target.CompareTag("Player"))
        {
            Teleport.Play();
           // new WaitForSeconds(0.3f);
            SceneManager.LoadScene("Level1");
        }

    }

}
