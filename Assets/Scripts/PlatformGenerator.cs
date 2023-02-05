using System;
using UnityEngine;

public class PlatformGenerator : MonoBehaviour
{
    public GameObject platformPrefab;
    public float platformWidth = 4.0f;
    public float maxSpawnHeight = 5.0f;
    public float minSpawnHeight = -5.0f;

    void Start()
    {
        // Start generating off screen platforms at random heights
        InvokeRepeating("GeneratePlatform", 0.0f, 1.0f);
    }
    
    void GeneratePlatform()
    {
        // Generate a random height
        float spawnHeight = UnityEngine.Random.Range(minSpawnHeight, maxSpawnHeight);
        // Instantiate a platform at the random height
        Instantiate(platformPrefab, new Vector2(transform.position.x, spawnHeight), Quaternion.identity);
    }
}
