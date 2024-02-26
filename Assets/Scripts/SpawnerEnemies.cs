using System.Collections;
using UnityEngine;

public class SpawnerEnemies : MonoBehaviour
{
    [SerializeField] private MoverEnemy _enemyPrefab;
    [SerializeField] private Transform _target;

    private MoverEnemy _enemy;

    private void Start()
    {
        float minTimeWaitSpawnEnemy = 1f;
        float maxTimeWaitSpawnEnemy = 3f;

        float randomTimeWaitSpawnEnemy = Random.Range(minTimeWaitSpawnEnemy, maxTimeWaitSpawnEnemy);

        StartCoroutine(WaitingEnemiesCreated(randomTimeWaitSpawnEnemy, _enemy));
    }

    private MoverEnemy CreateEnemy()
    {
        return Instantiate(_enemyPrefab, transform.position, Quaternion.identity);
    }

    private void SendPositionTarget(MoverEnemy enemy)
    {
        enemy.AcceptPosition(_target);
    }

    private IEnumerator WaitingEnemiesCreated(float timeWait, MoverEnemy enemy)
    {
        bool isWorkCreateEmemies = true;

        var wait = new WaitForSeconds(timeWait);

        while (isWorkCreateEmemies)
        {
            enemy = CreateEnemy();

            SendPositionTarget(enemy);

            yield return wait;
        }
    }
}
