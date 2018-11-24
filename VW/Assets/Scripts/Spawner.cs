using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    public GameObject enemy;
    public bool canSpawn;
    public int amount = 0;
    public float spawnInterval = 0f;

    private float time;


	// Use this for initialization
	void Start () {
        time = spawnInterval;
		
	}
	
	// Update is called once per frame
	void Update () {
        if (canSpawn)
        {
            Timer();
        }

	}

    void Timer() {
        time -= Time.deltaTime;
        if (time <= 0f)
        {
            SpawnEnemy();
            time = spawnInterval;
        }

    }

    void SpawnEnemy() {
        GameObject _spawnedEnemy = Instantiate(enemy, transform.position, Quaternion.identity);
    }
}
