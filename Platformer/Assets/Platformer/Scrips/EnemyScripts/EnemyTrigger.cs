using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTrigger : MonoBehaviour
{
   [SerializeField] private Collision2D _collision2D;

   public delegate void Dead();
   public static event  Dead OnDieEnemy;
   private void OnCollisionEnter2D(Collision2D other)
   {
      Destroy(this.gameObject);
      OnDieEnemy?.Invoke();
   }
}
