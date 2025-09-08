using UnityEngine;

public class WaveManager : MonoBehaviour
{
    public GameObject[] enemyPrefabs;
    public Transform[] spawnPoints;
    public float spawnInterval = 3f;
    private int waveNumber = 1;

    void Start()
    {
        InvokeRepeating("SpawnWave", 2f, spawnInterval);
    }

    void SpawnWave()
    {
        int enemiesToSpawn = waveNumber + 2;
        for (int i = 0; i < enemiesToSpawn; i++)
        {
            int randEnemy = Random.Range(0, enemyPrefabs.Length);
            int randSpawn = Random.Range(0, spawnPoints.Length);
            Instantiate(enemyPrefabs[randEnemy], spawnPoints[randSpawn].position, Quaternion.identity);
        }
        waveNumber++;
    }
}

