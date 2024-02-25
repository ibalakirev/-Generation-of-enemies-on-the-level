using UnityEngine;

public class SpawnerEnemies : MonoBehaviour
{
    [SerializeField] private Transform _enemyPrefab;
    [SerializeField] private Transform _firstPurpos;
    [SerializeField] private Transform _secondPurpos;
    [SerializeField] private Transform _thirdPurpos;

    public Transform FirstPurpos => _firstPurpos;
    public Transform SecondPurpos => _secondPurpos;
    public Transform ThirdPurpos => _thirdPurpos;

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

    public Vector3 GetMoveEnemyPosition(Vector3 position, Vector3 direction, float speed)
    {
        return Vector3.MoveTowards(position, direction, speed * Time.deltaTime);
    }
}
