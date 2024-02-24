using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Transform _enemyPrefab;

    private Vector3 _directionEnemy = new Vector3(-1.9f, 0f, -0.3f);

    public Vector3 DirectionEnemy => _directionEnemy;

    private void Start()
    {
        float minTimeWaitSpawnEnemy = 1f;
        float maxTimeWaitSpawnEnemy = 3f;

        float randomTimeWaitSpawnEnemy = Random.Range(minTimeWaitSpawnEnemy, maxTimeWaitSpawnEnemy);

        InvokeRepeating(nameof(CreateEnemy), randomTimeWaitSpawnEnemy, randomTimeWaitSpawnEnemy);
    }

    private void CreateEnemy()
    {
        Instantiate(_enemyPrefab, transform.position, Quaternion.identity);
    }
}
