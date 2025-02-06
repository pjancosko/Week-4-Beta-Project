using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    public GameObject cubePrefab;
    public int numberOfCubes = 10;
    public float spawnRadius = 10.0f;

    void Start()
    {
        for (int i = 0; i < numberOfCubes; i++)
        {
            Vector3 spawnPosition = new Vector3(
                Random.Range(-spawnRadius, spawnRadius),
                1.0f, // Assuming the ground is at y = 0
                Random.Range(-spawnRadius, spawnRadius)
            );

            Instantiate(cubePrefab, spawnPosition, Quaternion.identity);
        }
    }
}