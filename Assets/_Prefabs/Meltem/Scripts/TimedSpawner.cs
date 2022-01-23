using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimedSpawner : MonoBehaviour
{

    public GameObject [] spawnee;
    public float spawnTime;
    public float spawnDelay;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObject", spawnTime, spawnDelay);
    }
    public void SpawnObject()
    {
        Instantiate(spawnee[UnityEngine.Random.Range(0,9)], transform.position, transform.rotation);

    }
}
   

