using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject _enemyPrefab;

    private Vector3 _directionEnemy;

    public Vector3 DirectionEnemy => _directionEnemy = new Vector3(-1.9f, 0f, -0.3f);

    void Start()
    {
        float minTimeWaitSpawnEnemy = 1f;
        float maxTimeWaitSpawnEnemy = 3f;

        float randomTimeWaitSpawnEnemy = Random.Range(minTimeWaitSpawnEnemy, maxTimeWaitSpawnEnemy);

        InvokeRepeating(nameof(CreateEnemy), randomTimeWaitSpawnEnemy, randomTimeWaitSpawnEnemy);
    }

    private void CreateEnemy()
    {
        float axisX = 0f;
        float axisY = 0f;
        float axisZ = 0f;

        Instantiate(_enemyPrefab, transform.position, Quaternion.Euler(axisX, axisY, axisZ));
    }
}
