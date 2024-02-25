using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Transform _enemyPrefab;
    [SerializeField] private Transform _firstPurpos;
    [SerializeField] private Transform _secondPurpos;
    [SerializeField] private Transform _thirdPurpos;

    private void Start()
    {
        float minTimeWaitSpawnEnemy = 1f;
        float maxTimeWaitSpawnEnemy = 3f;

        float randomTimeWaitSpawnEnemy = Random.Range(minTimeWaitSpawnEnemy, maxTimeWaitSpawnEnemy);

        InvokeRepeating(nameof(CreateEnemy), randomTimeWaitSpawnEnemy, randomTimeWaitSpawnEnemy);
    }

    public Vector3 GetMoveEnemyPositionFirstFighter(Vector3 position, float speed)
    {
        return GetMoveEnemyPosition(position, _firstPurpos.transform.position, speed);
    }

    public Vector3 GetMoveEnemyPositionSecondFighter(Vector3 position, float speed)
    {
        return GetMoveEnemyPosition(position, _secondPurpos.transform.position, speed);
    }

    public Vector3 GetMoveEnemyPositionThirdFighter(Vector3 position, float speed)
    {
        return GetMoveEnemyPosition(position, _thirdPurpos.transform.position, speed);
    }

    private void CreateEnemy()
    {
        Instantiate(_enemyPrefab, transform.position, Quaternion.identity);
    }

    private Vector3 GetMoveEnemyPosition(Vector3 position, Vector3 direction, float speed)
    {
        return Vector3.MoveTowards(position, direction, speed * Time.deltaTime);
    }
}
