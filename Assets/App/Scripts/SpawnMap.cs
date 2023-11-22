using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMap : MonoBehaviour
{
    [SerializeField] private GameObject _mapStartPrefabs;
    [SerializeField] private GameObject[] _mapPrefabs;
    [SerializeField] private List<Transform> _mapsList;
    [SerializeField] private List<MapMovement> _mapMovements;

    private void Start()
    {
        var gm = Instantiate(_mapStartPrefabs, new Vector3(0, 0, 0), Quaternion.identity);
        _mapsList.Add(gm.transform);
        for (int i = 0; i < 100; i++)
        {
            SpawnNewMap();
        }
        foreach (var map in _mapsList)
        {
            _mapMovements.Add(map.GetComponent<MapMovement>());
        }
        foreach (var map in _mapMovements)
        {
            map.SetSpeed(0);
        }
    }
    public void StartGameMap()
    {
        foreach (var item in _mapsList)
        {
            Destroy(item.gameObject);
        }
        _mapMovements.Clear();

        var gm = Instantiate(_mapStartPrefabs, new Vector3(0, 0, 0), Quaternion.identity);
        _mapsList.Add(gm.transform);
        for (int i = 0; i < 100; i++)
        {
            SpawnNewMap();
        }

        foreach (var map in _mapsList)
        {
            _mapMovements.Add(map.GetComponent<MapMovement>());
        }
        foreach (var map in _mapMovements)
        {
            map.SetSpeed(-2);
        }
    }
    void SpawnNewMap()
    {
        var random = Random.Range(0, _mapPrefabs.Length);
        var vectorZ = _mapsList[_mapsList.Count - 1].transform.position.z + 6;
        var gm = Instantiate(_mapPrefabs[random], new Vector3(0, 0, vectorZ), Quaternion.identity);
        _mapsList.Add(gm.transform);
    }
}
