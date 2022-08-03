using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratorController : MonoBehaviour
{
    // Start is called before the first frame update
    
    public GameObject[] enemyPrefebs;
    public float delaySpawn = 1f;
    public float intervalSpawn = 1f;

    void Start()
    {
        InvokeRepeating("SpawnEnemy", delaySpawn, intervalSpawn);
        

    }
    private void SpawnEnemy()
    {
        Instantiate(enemyPrefebs[0], transform); 

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
