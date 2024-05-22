using UnityEngine;

public class CameraFollow : MonoBehaviour
{
   [SerializeField] private Transform _targetTransform;
   [SerializeField] private Vector3 _offset;
   [SerializeField] private float _smoothSpeed = 0.125f;

   private void LateUpdate()
   {
      Vector3 desirePisition = new Vector3(_targetTransform.position.x, 0, -10) + _offset;
      Vector3 smoothPosition = Vector3.Lerp(transform.position, desirePisition, _smoothSpeed);
      transform.position = smoothPosition;
   }
}
