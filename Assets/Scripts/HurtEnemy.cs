using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HurtEnemy : MonoBehaviour {

    public int dmgToDeal;
    public GameObject damageBurst;
    public Transform hitPoint;

    public Text WinText;


    // Use this for initialization
    void Start () {
        WinText.gameObject.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {

	}

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            //Destroy(other.gameObject);

            other.gameObject.GetComponent<EnemyHealthManager>().HurtEnemy(dmgToDeal);

            Instantiate(damageBurst, hitPoint.position, hitPoint.rotation);
            if (other.gameObject.name == "Boss" )
            {
                if (other.gameObject.GetComponent<EnemyHealthManager>().CurrentHealth == 0)
                {
                    WinnerText();
                }
            }
        }


    }
    public void WinnerText()
    {
        WinText.gameObject.SetActive(true);

    }
}
