using UnityEngine;

public class MoverEnemy : MonoBehaviour
{
    [SerializeField] private float _speed;

    private Spawner _spawner;
    private Vector3 _direction;

    private void Awake()
    {
        string nameSpawnTag = "Spawn";

        _spawner = GameObject.FindGameObjectWithTag(nameSpawnTag).GetComponent<Spawner>();

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
