using UnityEngine;

public class MoverTarget : MonoBehaviour
{
    [SerializeField] private Transform[] _patrolPoints;
    [SerializeField] private float _speed;

    private int _randomPatrolPosition;

    private void Start()
    {
        RandomizePatrolPoint();
    }

    private void FixedUpdate()
    {
        Patrol();
    }

    private void Patrol()
    {
        float minDistance = 0.2f;

        transform.position = Vector3.MoveTowards(transform.position, _patrolPoints[_randomPatrolPosition].position,
            _speed * Time.deltaTime);

        if (Vector3.Distance(transform.position, _patrolPoints[_randomPatrolPosition].position) < minDistance)
        {
            RandomizePatrolPoint();
        }
    }

    private void RandomizePatrolPoint()
    {
        int minIndexPatrolPoint = 0;
        int maxIndexPatrolPoint = _patrolPoints.Length;

        _randomPatrolPosition = Random.Range(minIndexPatrolPoint, maxIndexPatrolPoint);
    }

}
