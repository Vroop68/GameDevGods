using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealthManager : MonoBehaviour
{

    public int MaxHealth;
    public int CurrentHealth;



    //This script will be used to manage the health of enemies.
    // Use this for initialization
    void Start()
    {
        CurrentHealth = MaxHealth;

    }

    // Update is called once per frame
    void Update()
    {
        if (CurrentHealth <= 0)
        {
            Destroy(gameObject);
        }
    }

    public void HurtEnemy(int damageToDeal)
    {
        CurrentHealth -= damageToDeal;
    }

    public void SetMaxHealth()
    {
        CurrentHealth = MaxHealth;
    }
}
