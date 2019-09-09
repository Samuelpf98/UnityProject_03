using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSpawner : MonoBehaviour
{

    public Transform[] spawnpoints;
    public int EnemiesToSpawn;
    public GameObject[] Enemies;
    private int EnemiesSpawned = 0;
    private List<int> usedSlots = new List<int>();

    // Start is called before the first frame update
    void Start()
    {

        while (EnemiesToSpawn != 0)
        {
            SpawnArea();
            EnemiesToSpawn--;
        }

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void SpawnArea()
    {


        int SpawnPoints2 = Random.Range(0, spawnpoints.Length);
        if (usedSlots.Contains(SpawnPoints2))
        {
            
            SpawnArea();
        }
        else
        {
            usedSlots.Add(SpawnPoints2);
            int randomEnemy = Random.Range(0, Enemies.Length);
            Instantiate(Enemies[randomEnemy], spawnpoints[SpawnPoints2].position, Quaternion.identity);
            EnemiesSpawned++;
        }
    }
}
