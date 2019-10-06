using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    //This script manages the basic UI elements
    public Slider healthBar;
    public Text hpText;
    public PlayerHealthManager playerHealth;


    // Use this for initialization
    void Start()
    {

    }


    void Update()
    {
        //Health bar and text are updated when the player takes damage or the game starts
        healthBar.maxValue = playerHealth.playerMaxHealth;
        healthBar.value = playerHealth.playerCurrentHealth;
        hpText.text = "Health: " + playerHealth.playerCurrentHealth + "/" + playerHealth.playerMaxHealth;
    }
}
