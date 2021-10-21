using UnityEngine;

public class RandomSpawner : MonoBehaviour
{
    [SerializeField] private int amount;
    [SerializeField] private GameObject prefab;
    [SerializeField] private Collider2D spawnZone;
    
    private void Awake()
    {
        for (int i = 0; i < amount; i++)
            SpawnPrefabAtRandomLocation();
    }

    private void SpawnPrefabAtRandomLocation()
    {
        Vector3 randomPosition = GetRandomLocationInBounds();
        Instantiate(prefab, randomPosition, Quaternion.identity);
    }

    private Vector3 GetRandomLocationInBounds()
    {
        Bounds spawningBounds = spawnZone.bounds;
        Vector3 center = spawningBounds.center;
        Vector3 extents = spawningBounds.extents;

        float randomX = Random.Range(-extents.x, extents.x);
        float randomY = Random.Range(-extents.y, extents.y);
        
        return center + new Vector3(randomX, randomY);
    }
}