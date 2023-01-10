using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public float smoothSpeed = 0.125f;
    public Vector3 offset;
    public float rotationSpeed = 10f;
    private Vector3 currentVelocity;
    private Vector3 lastDirection;

    void LateUpdate()
    {
        Vector3 direction = target.position - transform.position;

        if (direction != lastDirection)
        {
            lastDirection = direction;

            Quaternion targetRotation = Quaternion.LookRotation(direction);
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);
        }

        Vector3 desiredPosition = target.position + offset;

        Vector3 smoothedPosition = Vector3.SmoothDamp(transform.position, desiredPosition, ref currentVelocity, smoothSpeed);

        transform.position = smoothedPosition;
    }
}