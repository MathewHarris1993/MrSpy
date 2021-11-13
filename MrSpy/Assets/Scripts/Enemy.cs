using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    //variables
    public float enemySpeed = 5;
    private Rigidbody enemyRb;
    private GameObject player;
    public bool activateEnemy = true;


    // Start is called before the first frame update
    void Start()
    {

        enemyRb = GetComponent<Rigidbody>();
        player = GameObject.Find("Player");

    }

    // Update is called once per frame
    void Update()
    {
        //vector
        Vector3 lookDirection = (player.transform.position - transform.position).normalized;
        

        if( activateEnemy == true)
        {
            transform.Translate(lookDirection * Time.deltaTime * enemySpeed);

        }


    }
}
