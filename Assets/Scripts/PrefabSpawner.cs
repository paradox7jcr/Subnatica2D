using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabSpawner : MonoBehaviour
{
    private float nextSpawnTime;
    private float spawnDelay;

    [SerializeField]
    private GameObject[] prefabs;

    private Camera myCamera;

    // Start is called before the first frame update
    void Start()
    {
        var blueGem = Resources.Load<GameObject>("Prefabs/blue_gem");
        var greenGem = Resources.Load<GameObject>("Prefabs/green_gem");
        var redGem = Resources.Load<GameObject>("Prefabs/red_gem");
        var whiteGem = Resources.Load<GameObject>("Prefabs/white_gem");
        prefabs = new [] { blueGem, greenGem, redGem, whiteGem };
        spawnDelay = 5;
        this.myCamera = FindObjectOfType<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        if (ShouldSpawn())
        {
            Spawn();
        }
    }

    private void Spawn()
    {
        Vector3 spawnPosition = Camera.main.ViewportToWorldPoint(new Vector3(Random.value, Random.value, 10));
        Instantiate(prefabs[Random.Range(0, 4)], spawnPosition, transform.rotation);
        nextSpawnTime = Time.time + spawnDelay;
    }

    private bool ShouldSpawn()
    {
        return Time.time > nextSpawnTime;
    }
}
