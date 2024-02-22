using System.Collections.Generic;
using UnityEngine;

public class DiamondSpawner : MonoBehaviour
{
    [SerializeField] private Diamond _diamondPrefab;
    [SerializeField] private Transform _spawnerPointConteiner;
    [SerializeField] private DiamondGatherer _gatherer;

    private Queue<Transform> _spawnerPoints = new Queue<Transform>();

    private void Awake()
    {
        for (int i = 0; i < _spawnerPointConteiner.childCount; i++)
            _spawnerPoints.Enqueue(_spawnerPointConteiner.GetChild(i));
    }

    private void Start()
    {
        CreateDiamond();
    }

    private void OnEnable()
    {
        _gatherer.TookDiamond += CreateDiamond;
    }

    private void OnDisable()
    {
        _gatherer.TookDiamond -= CreateDiamond;
    }

    private void CreateDiamond()
    {
        if (_spawnerPoints.Count != 0)
            Instantiate(_diamondPrefab, _spawnerPoints.Dequeue());
    }
}