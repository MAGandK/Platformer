using UnityEngine;

public class CameraFollow : MonoBehaviour
{
   [SerializeField] private Transform _targetTransform;
   [SerializeField] private Vector3 _offset;
   [SerializeField] private float _smoothSpeed = 0.125f;
   [SerializeField] private float _maxX = 55f;
   [SerializeField] private float _minX = 0f;

   private void LateUpdate()
   {
      Vector3 desiredPosition = new Vector3(_targetTransform.position.x, 0, -10) + _offset;
      
      desiredPosition.x = Mathf.Clamp(desiredPosition.x, _minX, _maxX);
      
      Vector3 smoothPosition = Vector3.Lerp(transform.position, desiredPosition, _smoothSpeed);
      
      transform.position = smoothPosition;
   }
}

