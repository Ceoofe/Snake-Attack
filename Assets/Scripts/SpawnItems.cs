using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnItems : MonoBehaviour
{
    public GameObject[] itemsPrefabs;
    private float spawnRangeX = 7f;
    private float spawnRangeZ = 7f;
    private float delay = 2f;
    private float spawninterval = 3f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Clone", delay, spawninterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void Clone()
    {
        int itemsIndex = Random.Range(0, itemsPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 10, Random.Range(-6.5f, spawnRangeZ));
        Instantiate(itemsPrefabs[itemsIndex], spawnPos, itemsPrefabs[itemsIndex].transform.rotation);
    }
}
