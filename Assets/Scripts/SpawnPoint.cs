using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    [SerializeField] private Enemy _enemyPrefab;
    [SerializeField] private Target[] _targets;

    public void Spawn()
    {
        Enemy enemy = Instantiate(_enemyPrefab);
        enemy.Init(transform.position, _targets[Random.Range(0, _targets.Length)]);
    }
}
