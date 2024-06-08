using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField] private Enemy _enemy;

    private void Start()
    {
        _enemy.GetComponent<Enemy>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Ball") || other.gameObject.CompareTag("Player"))
        {
            _enemy.DiedEnemy();
        }
    }
}
