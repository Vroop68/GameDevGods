using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealthManager : MonoBehaviour {

    public int playerMaxHealth;
    public int playerCurrentHealth;


    private GameObject thePlayer;


    // Use this for initialization
    void Start () {
        playerCurrentHealth = playerMaxHealth;
		
	}
	
	// Update is called once per frame
	void Update () {
        if (playerCurrentHealth <= 0)
        {
            gameObject.SetActive(false);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            thePlayer.SetActive(true);
        }
	}

    public void HurtPlayer(int damageToDeal)
    {
        playerCurrentHealth -= damageToDeal;
    }

    public void SetMaxHealth()
    {
        playerCurrentHealth = playerMaxHealth;
    }

}
