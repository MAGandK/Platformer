using UnityEngine;

public class UIController : MonoBehaviour
{
    [SerializeField] private Transform _canvasParrentTransform;
    [SerializeField] private GameObject _uiPopup;
    private bool _isPause;

    private void Start()
    {
        GameObject pupap = Instantiate(_uiPopup);
        
        pupap.transform.SetParent(_canvasParrentTransform,false);

        RectTransform rectTransform = pupap.GetComponent<RectTransform>();
        
        rectTransform.anchoredPosition = Vector2.zero;
        rectTransform.sizeDelta = new Vector2(500, 400);

        //Time.timeScale = 0;

    }
}
