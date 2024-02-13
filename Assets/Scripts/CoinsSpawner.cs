using UnityEngine;

public class CoinsSpawner : MonoBehaviour
{
    [SerializeField] private Coin _coinPrefab;
    [SerializeField] private Transform _spawnPoinConteiner;

    private Transform[] _spawnPoints;

    private void Awake()
    {
        _spawnPoints = new Transform[_spawnPoinConteiner.childCount];

        for (int i = 0; i < _spawnPoinConteiner.childCount; i++)
            _spawnPoints[i] = _spawnPoinConteiner.GetChild(i);
    }
}