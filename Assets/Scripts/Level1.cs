using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level1 : MonoBehaviour
{
<<<<<<< HEAD
    void OnTriggerEnter2D(Collider2D target)
    {

        if (target.tag == "Player")
        {
            SceneManager.LoadScene("Level1");

            //Teleport sound to be added here.

            // play explosion sound
            //explosionSound.Play();
            //anim.Play("Destroy");

=======
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
>>>>>>> master
        }

    }

}
