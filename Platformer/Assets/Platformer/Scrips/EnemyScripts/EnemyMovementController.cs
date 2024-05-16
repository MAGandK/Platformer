using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovementController : MonoBehaviour
{
    private EnemyX _enemy;

    private void Start()
    {
        _enemy = GetComponent<EnemyX>();
    }

    private void Update()
    {
        _enemy.MovmentEnemy();
    }
}
