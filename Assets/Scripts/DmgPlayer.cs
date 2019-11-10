using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DmgPlayer : MonoBehaviour
{

    public int DmgToDeal;//Amount of damage dealt to the playr upon collision

    //Causes the object named "Player" to take damage when it collides with an object attached to this script.
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.name == "Player")
        {
            other.gameObject.GetComponent<PlayerHealthManager>().HurtPlayer(DmgToDeal);
        }
    }

}
