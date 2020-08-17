using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Spawner : MonoBehaviour {
    public GameObject enemy;
    public GameObject enemy2;
    public GameObject enemy3;
    public Transform[] spawnSpots; // array for the spawner for random spawn spots
    private float timeBtwSpawns;
    public float startTimeBtwSpawns;

    void Start() {
        timeBtwSpawns = startTimeBtwSpawns;
        StartCoroutine(scheduleIncrease());
        StartCoroutine(scheduleIncrease2());
    }

    void Update() {
        if (timeBtwSpawns <= 0) { //if it is less than or equal to 0 its time to spawn
            int randPos = Random.Range(0, spawnSpots.Length); //defines the random position
            Instantiate(enemy, spawnSpots[randPos].position, Quaternion.identity); // spawns enemy at random position with no rotation
            timeBtwSpawns = startTimeBtwSpawns; // This stops the enemy spawning every frame
        } else {
            timeBtwSpawns -= Time.deltaTime; // if it is not less than or equal to zero it is going to decrease the timeBtwSpawns
        }
    }

    void IncreaseSpawnRate() {
        if (startTimeBtwSpawns > 0.5f) {
            startTimeBtwSpawns-= 0.20f; 
            if (startTimeBtwSpawns < 0.5f) {
                startTimeBtwSpawns = 0.5f;
            }
        }
            Debug.Log(timeBtwSpawns);
            Debug.Log(startTimeBtwSpawns);
    }

    void NewEnemy2() {
        int randPos = Random.Range(0, spawnSpots.Length); //defines the random position
        Instantiate(enemy2, spawnSpots[randPos].position, Quaternion.identity); // spawns enemy at random position with no rotation
        timeBtwSpawns = startTimeBtwSpawns; // This stops the enemy spawning every frame
    }

    void NewEnemy3() {
        int randPos = Random.Range(0, spawnSpots.Length); //defines the random position
        Instantiate(enemy3, spawnSpots[randPos].position, Quaternion.identity); // spawns enemy at random position with no rotation
        timeBtwSpawns = startTimeBtwSpawns; // This stops the enemy spawning every frame
    }

    private IEnumerator scheduleIncrease() {
        while (startTimeBtwSpawns != 0.5f) {
            yield return new WaitForSeconds(20f);
            IncreaseSpawnRate();
        }

        while (startTimeBtwSpawns <= 0.5f) {
            yield return new WaitForSeconds(15f);
            NewEnemy3();
        }
    }

    private IEnumerator scheduleIncrease2() {
        if(startTimeBtwSpawns <= 1f){
            yield return new WaitForSeconds(10f);
        while (startTimeBtwSpawns <= 1f) {
            yield return new WaitForSeconds(7.5f);
            NewEnemy2();
        }
        }
    }
}