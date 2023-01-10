using UnityEngine;

public class CameraSc : MonoBehaviour
{
    public Transform target;
    public float distance = 20f;
    public float smoothSpeed = 0.125f;
    public Vector3 offset;
    public float rotationSpeed = 10f;
    public float lookAheadDistance = 1.5f;
    private Vector3 currentVelocity;
    private Vector3 lastDirection;
    private Vector3 currentDirection;
    private Vector3 lookAheadPos;

    void LateUpdate()
    {
        currentDirection = target.position - transform.position;

        if (currentDirection != lastDirection)
        {
            lastDirection = currentDirection;
            lookAheadPos = target.position + currentDirection.normalized * lookAheadDistance;

            Quaternion targetRotation = Quaternion.LookRotation(lookAheadPos - transform.position);
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);
        }

        Vector3 desiredPosition = target.position + offset;

        Vector3 smoothedPosition = Vector3.SmoothDamp(transform.position, desiredPosition, ref currentVelocity, smoothSpeed);

        transform.position = smoothedPosition;
    }
}