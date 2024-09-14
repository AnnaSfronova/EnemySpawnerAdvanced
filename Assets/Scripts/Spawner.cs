using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private SpawnPoint[] _spawnPoints;

    private void Start()
    {
        StartCoroutine(SpawnEnemies());
    }

    private IEnumerator SpawnEnemies()
    {
        float delay = 1f;
        WaitForSeconds wait = new(delay);

        while (true)
        {
            _spawnPoints[Random.Range(0, _spawnPoints.Length)].Spawn();
            yield return wait;
        }
    }
}
