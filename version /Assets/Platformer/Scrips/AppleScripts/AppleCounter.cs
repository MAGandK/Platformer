using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class AppleCounter : MonoBehaviour
{
    [SerializeField] private TMP_Text _countText;
    private int _appleCount = 0;
    
    private void Start()
    {
        UpdateAppleCountText();
    }

    public void CountAppls()
    {
        _appleCount++;
        UpdateAppleCountText();
    }
   
    private void UpdateAppleCountText()
    {
        _countText.text = $"Count: {_appleCount.ToString()}";
    }
}
