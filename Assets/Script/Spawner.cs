using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Scoring score;
    public GameObject Prefab;
    public float spawnRate;
    public float minHeight = -1f;
    public float maxHeight = 1f;

    private void OnEnable()
    {
        InvokeRepeating(nameof(Spawn), spawnRate, spawnRate);
    }

    private void OnDisable()
    {
        CancelInvoke(nameof(Spawn));
    }

    private void Spawn()
    {
        GameObject Pipes = Instantiate(Prefab, transform.position, Quaternion.identity);
        Pipes.transform.position += Vector3.up * Random.Range(minHeight, maxHeight);
        if( score.Currentscore % 5 == 1)
        {
            spawnRate = spawnRate - 0.2f;
            Debug.Log("kecepatan berkurang");
        }
    }
}
