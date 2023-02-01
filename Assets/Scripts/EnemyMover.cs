using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMover : MonoBehaviour
{
    [SerializeField] private Transform _path;

    private float _speed;

    private Transform[] _points;
    private int _currentPoint;

    private void Start()
    {
        _points = new Transform[_path.childCount];

        for (int i = 0; i < _path.childCount; i++)
        {
            _points[i] = _path.GetChild(i);
        }
    }

    private void Update()
    {
        Transform target = _points[_currentPoint];
        SelectSpeed();

        transform.position = Vector3.MoveTowards(transform.position, target.position, _speed * Time.deltaTime);

        if (transform.position == target.position)
        {
            _currentPoint++;
        }

        if (_currentPoint == _path.childCount)
        {
            _currentPoint = 0;
        }
    }

    private void SelectSpeed()
    {
        int minSpeed = 1;
        int maxSpeed = 10;
        System.Random random = new System.Random();
        _speed = random.Next(minSpeed, maxSpeed);
    }
}


