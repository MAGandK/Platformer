using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RestartWindow : MonoBehaviour
{
    [SerializeField] private Button _buttonRestart;

    private void Start()
    {
        Time.timeScale = 0;
        _buttonRestart.onClick.AddListener(OnRestartButtonClick);
    }
    
    private void OnRestartButtonClick()
    {
        Time.timeScale = 1;
        GameManader.Instance.RestartLevel();
    }
}
