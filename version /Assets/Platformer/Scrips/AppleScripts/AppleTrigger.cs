using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using PlayerSpase;

public class AppleTrigger : MonoBehaviour
{
    [SerializeField] private Collision2D _collision2D;
    [SerializeField] private AppleCounter _counter;
    private void OnCollisionEnter2D(Collision2D other)
    {
        _counter.CountAppls();
        Destroy(this.gameObject);
    }
}
