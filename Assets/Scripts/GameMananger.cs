using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;
using Random = UnityEngine.Random;

public class GameMananger : MonoBehaviour
{
    [SerializeField] GameObject ringPrefab;
    [SerializeField] GameObject backGroundPrefab;

    void Start()
    {
        Spawning();
        BgSpawning();
    }

    private void BgSpawning()
    {
        StartCoroutine(BackGroundSpawning());
    }

    IEnumerator BackGroundSpawning()
    {
        Vector2 spawnPosition = new Vector2(11, -2);
        Instantiate(backGroundPrefab, spawnPosition, Quaternion.identity);
        yield return new WaitForSeconds(2.5f);
        BgSpawning();
    }

    private void Spawning()
    {
        StartCoroutine(SpawnProcess());
    }

    IEnumerator SpawnProcess()
    {
        float randomY = Random.Range(-2.3f, 2.1f);
        Vector2 spawnPosition = new Vector2(11, randomY);
        Instantiate(ringPrefab, spawnPosition, Quaternion.identity);
        yield return new WaitForSeconds(3f);
        Spawning();
    }
}
