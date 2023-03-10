using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnEnemy : MonoBehaviour {
    
    [SerializeField] private float spawnRate;
    [SerializeField] private GameObject[] enemyPrefabs;

    private void Start() {
        StartCoroutine(Spawner());
    }

    private IEnumerator Spawner() {
        WaitForSeconds wait = new WaitForSeconds(spawnRate);
        while (!smash2.isDestroyed){
            yield return wait;
            int random = Random.Range(0, enemyPrefabs.Length);
            GameObject enemyToSpawn =  enemyPrefabs[random];
            Instantiate(enemyToSpawn);
        }
    }
}
