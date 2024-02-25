using UnityEngine;

public class MoverEnemy : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField, Range(1f, 3f)] private int _spawnDetectionIndicator;

    private Spawner _spawner;

    private void Awake()
    {
        _spawner = FindObjectOfType<Spawner>();
    }

    private void FixedUpdate()
    {
        int numberIndicatorFirstSpawn = 1;
        int numberIndicatorSecondSpawn = 2;
        int numberIndicatorThirdSpawn = 3;

        if (_spawnDetectionIndicator == numberIndicatorFirstSpawn)
        {
            transform.position = _spawner.GetMoveEnemyPositionFirstFighter(transform.position, _speed);
        }

        if (_spawnDetectionIndicator == numberIndicatorSecondSpawn)
        {
            transform.position = _spawner.GetMoveEnemyPositionSecondFighter(transform.position, _speed);
        }

        if (_spawnDetectionIndicator == numberIndicatorThirdSpawn)
        {
            transform.position = _spawner.GetMoveEnemyPositionThirdFighter(transform.position, _speed);
        }
    }
}
