using System;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public static UIController Instance;
    
    [SerializeField] private Transform _canvasParrentTransform;
    [SerializeField] private GameObject _uiPopup;
    private bool _isPause;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance =this;
        }
    }
    public void ShowPopup()
    {
        GameObject pupap = Instantiate(_uiPopup);
        
        pupap.transform.SetParent(_canvasParrentTransform,false);

        RectTransform rectTransform = pupap.GetComponent<RectTransform>();
        
        rectTransform.anchoredPosition = Vector2.zero;
        rectTransform.sizeDelta = new Vector2(500, 400);
    }
}
