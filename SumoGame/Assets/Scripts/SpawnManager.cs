using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private GameObject enemyObject;

    private float spawnRange = 9;

    private void Start()
    {
        Instantiate(enemyObject, GenerateSpawnPosition(), enemyObject.transform.rotation);
    }

    private Vector3 GenerateSpawnPosition()
    {
        float spawnPosX = Random.RandomRange(-spawnRange, spawnRange);
        float spawnPosZ = Random.RandomRange(-spawnRange, spawnRange);
        Vector3 randomPosition = new Vector3(spawnPosX, 0, spawnPosZ);
        return randomPosition;
    }
}
