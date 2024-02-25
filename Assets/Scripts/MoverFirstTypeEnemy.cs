using UnityEngine;

public class MoverFirstTypeEnemy : MonoBehaviour
{
    [SerializeField] private float _speed;

    private SpawnerEnemies _spawnerEnemies;
    private Vector3 _direction;

    private void Awake()
    {
        _spawnerEnemies = FindObjectOfType<SpawnerEnemies>();
    }

    private void FixedUpdate()
    {
        Move();
    }

    private void Move()
    {
        _direction = _spawnerEnemies.FirstPurpos.transform.position;

        transform.position = _spawnerEnemies.GetMoveEnemyPosition(transform.position, _direction, _speed);
    }
}