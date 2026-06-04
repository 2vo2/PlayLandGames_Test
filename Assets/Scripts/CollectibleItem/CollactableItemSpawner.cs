using System.Collections.Generic;
using UnityEngine;

public class CollactableItemSpawner : MonoBehaviour
{
    [SerializeField] private List<BaseCollactableItem> _itemPrefabs;
    [SerializeField] private Vector2 _spawnRange;
    [SerializeField] private int _spawnSize;

    private List<BaseCollactableItem> _items = new List<BaseCollactableItem>();

    private void Start()
    {
        Spawn();
    }

    private void Spawn()
    {
        for (int i = 0; i < _spawnSize; i++)
        {
            var newItem = Instantiate(_itemPrefabs[RandomIndex()], RandomSpawnPosition(), Quaternion.identity, transform);

            _items.Add(newItem);
        }
    }

    private int RandomIndex()
    {
        return Random.Range(0, _itemPrefabs.Count);
    }

    private Vector3 RandomSpawnPosition()
    {
        var randomX = Random.Range(-_spawnRange.x, _spawnRange.x);
        var randomY = Random.Range(-_spawnRange.y, _spawnRange.y);
        return new Vector3(randomX, randomY, 0f);
    }
}
