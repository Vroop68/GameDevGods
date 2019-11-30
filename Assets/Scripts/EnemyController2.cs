using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Util;
public class EnemyController2 : MonoBehaviour
{
    public EnemyAnimState enemyAnimState;
    // Start is called before the first frame update
    void Start()
    {
        enemyAnimState = EnemyAnimState.WALK;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
