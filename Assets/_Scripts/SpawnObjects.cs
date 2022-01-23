using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;


public class SpawnObjects : MonoBehaviour
{   [SerializeField] GameObject[] go = new GameObject[3];
    [SerializeField] private Vector3[] spawnPoints = new Vector3[3];
    private float nextSpawnTime;
    [SerializeField]private float minSpawnTime;
    [SerializeField]private float maxSpawnTime;
    [SerializeField] float rotation;
    private void Update()
    {  
        if (ShouldSpawn())
        {
            Spawn();
        }
    }

    private void Spawn()
    {   
        float spawnDelay = Random.Range(minSpawnTime, maxSpawnTime);
        Debug.Log(spawnDelay.ToString());
        nextSpawnTime = Time.time + spawnDelay;
        var index = Random.Range(0, go.Length);
        var transform_points_index = Random.Range(0, go.Length);
        Instantiate(go[index], spawnPoints[transform_points_index], transform.rotation);
    }

    private bool ShouldSpawn()
    {   
        Debug.Log(nextSpawnTime.ToString());
        Debug.Log(Time.time.ToString());
        return Time.time >= nextSpawnTime;
        Debug.Log(Time.time.ToString());
    }
}
