using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] waves;
    public GameObject winingScreen; 
    public int currentEnemies;

    private int currentWaveNumber; 
    private Vector3 spawnPosition; 

 
    // Start is called before the first frame update
    void Start()
    {
        currentWaveNumber = 0; 
        spawnPosition = new Vector3(0, 3.5f, 0);

        SpawnWave();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    //Spawns wave and saves enemy number of wave. 
    private void SpawnWave()
    {
        //Spawns wave and saves wave in variable. 
        GameObject currentWave = Instantiate(waves[currentWaveNumber], spawnPosition, Quaternion.identity);

        //Uses wave variable to set spawner refernce in enemy controller and saves returned enemy number of wave. 
        currentEnemies = currentWave.GetComponent<EnemyController>().SetSpawnerReference(this);
    }


    //Reduces Enemy count number and spawn new wave if all enemies are dead. 
    public void ReduceEnemies ()
    {
        currentEnemies--; 
        if (currentEnemies <=0)
        {
            if (currentWaveNumber < waves.Length-1) 
            {
                currentWaveNumber++;
                StartCoroutine(RecoverTime());
            } 
            else 
            {
               winingScreen.SetActive(true);
            }
           
        }
    }

    //Sets 3 seconde recover time before new wave starts 
    private IEnumerator RecoverTime ()
    {
        yield return new WaitForSeconds(3);
        DestroyProjectiles();
        SpawnWave();
    }

    //Destroys all GameObjects with the tag Projectile. 
    private void DestroyProjectiles()
    {
        GameObject[] projectiles = GameObject.FindGameObjectsWithTag("Projectile");
        foreach (GameObject projectile in projectiles)
        {
            GameObject.Destroy(projectile);
        }
    }
}
