using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    //variables
    public GameObject enemyPrefab;
    public int enemyCount;
    public int waveNumber = 1;
    public GameObject player;
    Vector3 spawnOne = new Vector3(10, 1, 10);
    Vector3 spawnTwo = new Vector3(0, 1, 10);
    Vector3 spawnThree = new Vector3(-10, 1, 10);

    // Start is called before the first frame update
    void Start()
    {
        //spawn enemy
        SpawnEnemyWaves(waveNumber);
    
    }

    // Update is called once per frame
    void Update()
    {
        
        enemyCount = FindObjectsOfType<Enemy>().Length;
        

        if (enemyCount == 0)
        {
       
            Instantiate(enemyPrefab, spawnOne, enemyPrefab.transform.rotation);
            Instantiate(enemyPrefab, spawnTwo, enemyPrefab.transform.rotation);
            Instantiate(enemyPrefab, spawnThree, enemyPrefab.transform.rotation);
        }
    }
   
    //spawn multiple enemies
    void SpawnEnemyWaves(int enemiesToSpawn)
    {
            

            Instantiate(enemyPrefab,spawnOne , enemyPrefab.transform.rotation);
            Instantiate(enemyPrefab, spawnTwo, enemyPrefab.transform.rotation);
            Instantiate(enemyPrefab, spawnThree, enemyPrefab.transform.rotation);
    }



}
