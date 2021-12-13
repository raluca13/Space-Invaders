using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] waves;
    private Vector3 spawnPosition; 

    // Start is called before the first frame update
    void Start()
    {
        spawnPosition = new Vector3(0, 3.5f, 0);

        SpawnWave(0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void SpawnWave(int pNumber)
    {
        Instantiate(waves[pNumber], spawnPosition, Quaternion.identity);
    }
}
