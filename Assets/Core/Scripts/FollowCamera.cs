using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [Tooltip("GameObject to follow")]
    public GameObject followGameObject;
    [Tooltip("Follow GameObject from specific height")]
    public float followHeight = 5f;
    [Tooltip("Follow GameObject from specific distance")]
    public float followDistance = 5f;
    [Tooltip("Offset rotation based on target's velocity")]
    public float followVelocityOffset = 2f;
    [Tooltip("How quickly the camera rotates to follow the target")]
    public float rotationRate = 360f;

    private void FixedUpdate()
    {
        if (!followGameObject) return;

        Vector3 position = followGameObject.transform.position;
        Vector3 forward = Vector3.zero;

        Rigidbody rigidbody = followGameObject.GetComponent<Rigidbody>();
        if (rigidbody){
            forward = rigidbody.velocity;
            forward.y = 0f;
            forward.Normalize();
        }

        Vector3 directionToGameObject = position - transform.position;
        directionToGameObject.y = 0f;
        directionToGameObject.Normalize();

        Vector3 finalPosition = position + (-directionToGameObject * followDistance);
        finalPosition += Vector3.up * followHeight;

        transform.position = finalPosition;
        Quaternion rotation = Quaternion.LookRotation((position + forward * followVelocityOffset) - transform.position);
        rotation = Quaternion.RotateTowards(transform.rotation, rotation, rotationRate * Time.fixedDeltaTime);
        transform.rotation = rotation;
    }
}
