using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    [SerializeField] private GameObject enemy, asteroid;
    [SerializeField] private float asteroidCounter, enemyWaveCounter;
    [SerializeField] private Collider2D topSpawnArea, sideSpawnArea;
    [SerializeField] private int enemiesPerWave;

    private float asteroidTime,waveTime;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void ResolveAsteroids()
    {
        asteroidTime += Time.deltaTime;
        if(asteroidTime >= asteroidCounter)
        {
            asteroidTime = 0;

            var spawn = topSpawnArea.bounds;
            var randomPosition = spawn.center + new Vector3((Random.value-0.5f) * spawn.extents.x * 2, (Random.value - 0.5f) * spawn.extents.y * 2);

            var go = Instantiate(asteroid, randomPosition, new Quaternion());
        }
    }

    private void ResolveEnemies()
    {
        waveTime += Time.deltaTime;
        if (waveTime >= enemyWaveCounter)
        {
            waveTime = 0;
            for (int i = 0; i < enemiesPerWave; i++)
            {
                var spawn = sideSpawnArea.bounds;
                var randomPosition = spawn.center + new Vector3((Random.value - 0.5f) * spawn.extents.x * 2, (Random.value - 0.5f) * spawn.extents.y * 2);

                var go = Instantiate(enemy, randomPosition, new Quaternion());
            }            
        }
    }

    // Update is called once per frame
    void Update()
    {
        ResolveAsteroids();
        ResolveEnemies();
    }
}
