using UnityEngine;

public class MoverEnemy : MonoBehaviour
{
    [SerializeField] private float _speed;

    private Spawner _spawner;
    private Vector3 _direction;

    private void Awake()
    {
        _spawner = FindObjectOfType<Spawner>();

        _direction = _spawner.DirectionEnemy;
    }

    private void FixedUpdate()
    {
        Move();
    }

    private void Move()
    {
        transform.position = Vector3.MoveTowards(transform.position, _direction, _speed * Time.deltaTime);
    }
}
