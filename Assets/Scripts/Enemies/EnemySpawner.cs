using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private Enemy _enemyPrefab;
    [SerializeField] private Transform _spawnPointConteiner;

    private void Awake()
    {
        for (int i = 0; i < _spawnPointConteiner.childCount; i++)
        {
            SpawnEnemy(_spawnPointConteiner.GetChild(i).position);
        }
    }

    private void SpawnEnemy(Vector3 position)
    {
        Instantiate(_enemyPrefab, position, Quaternion.identity);
    }
}