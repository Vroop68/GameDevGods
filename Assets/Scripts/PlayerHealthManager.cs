using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealthManager : MonoBehaviour
{
    //This script manages the health of the player
    public int playerMaxHealth;
    public int playerCurrentHealth;


    private GameObject thePlayer;


    // Use this for initialization
    void Start()
    {
        playerCurrentHealth = playerMaxHealth;

    }

    // Update is called once per frame
    void Update()
    {
        //When the player loses all their health the game is reset
        if (playerCurrentHealth <= 0)
        {
            gameObject.SetActive(false);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            gameObject.SetActive(true);
        }
    }
    //Calculates the damange the player takes
    public void HurtPlayer(int damageToDeal)
    {
        playerCurrentHealth -= damageToDeal;
    }
    //Sets the player to max health at the start of the game
    public void SetMaxHealth()
    {
        playerCurrentHealth = playerMaxHealth;
    }

}
