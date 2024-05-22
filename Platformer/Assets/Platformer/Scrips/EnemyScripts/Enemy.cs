using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class Enemy : MonoBehaviour
{
    [Header("Movement")]        
    [SerializeField] private float _enemySpeed = 1f;
    [SerializeField] private Transform _enemyTransform;
    [SerializeField] private Transform _targetPositionEnemy;
    [SerializeField] private Transform _targetPositionEnemyFlip;
    
    private Transform _currentTarget; 

    private bool _isFlip = true;
    
    private Rigidbody2D _rb;

    private void Start()
    {
        _currentTarget = _targetPositionEnemy; 
        _rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        MovmentEnemy();
    }

    private void MovmentEnemy()
    {
        _enemyTransform.position = Vector3.MoveTowards(_enemyTransform.position,
            _currentTarget.position, _enemySpeed * Time.deltaTime);
        if (_enemyTransform.position == _currentTarget.position)
        {
           FlipEnemy();
           SwitchTargetPosition();
        }
    }

    private void FlipEnemy()
    {
            _isFlip = !_isFlip;
            transform.Rotate(0, 180, 0);
        
    }
    private void SwitchTargetPosition()
    {
        if (_isFlip)
        {
            _currentTarget = _targetPositionEnemy;
        }
        else
        {
            _currentTarget = _targetPositionEnemyFlip;
        }
    }
}
