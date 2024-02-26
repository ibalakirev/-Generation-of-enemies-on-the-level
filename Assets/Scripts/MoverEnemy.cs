using UnityEngine;

public class MoverEnemy : MonoBehaviour
{
    [SerializeField] private float _speed;

    private Transform _targetPosition;

    private void Update()
    {
        Move();
    }

    public void AcceptPosition(Transform purpos)
    {
        _targetPosition = purpos;
    }

    public void Move()
    {
        transform.position = Vector3.MoveTowards(transform.position, _targetPosition.transform.position, _speed * Time.deltaTime);
    }
}
