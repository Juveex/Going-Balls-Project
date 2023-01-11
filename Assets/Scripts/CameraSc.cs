using UnityEngine;

public class CameraSc : MonoBehaviour
{
    public Transform target;
    public float distance = 20f;
    public float smoothSpeed = 0.125f;
    public Vector3 offset;
    public float rotationSpeed = 10f;
    public float lookAheadDistance = 1.5f;
    private Vector3 _currentVelocity;
    private Vector3 _lastDirection;
    private Vector3 _currentDirection;
    private Vector3 _lookAheadPos;
    public float minDistance = 5, maxDistance = 15;

    void LateUpdate()
    {
        _currentDirection = target.position - transform.position;

        // vector directed from the target to the camera
        Vector3 direction = transform.position - target.position;

        // Our ClampMagnitude
        if (direction.magnitude < minDistance)
        {
            direction = direction.normalized * minDistance;
        }
        if (direction.magnitude > maxDistance)
        {
            direction = direction.normalized * maxDistance;
        }

        transform.position = target.position + direction;

        if (_currentDirection != _lastDirection)
        {
            _lastDirection = _currentDirection;
            _lookAheadPos = target.position + _currentDirection.normalized * lookAheadDistance;

            Quaternion targetRotation = Quaternion.LookRotation(_lookAheadPos - transform.position);
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);
        }

        Vector3 desiredPosition = target.position + offset;

        Vector3 smoothedPosition = Vector3.SmoothDamp(transform.position, desiredPosition, ref _currentVelocity, smoothSpeed);

        transform.position = smoothedPosition;
    }
}