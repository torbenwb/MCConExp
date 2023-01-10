using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class InputMover2D : MonoBehaviour
{
    Rigidbody rigidbody;

    [Tooltip("How fast this object should move backwards / forwards.")]
    public float moveSpeed = 10f;
    [Tooltip("Name of move input axis.")]
    public string moveAxisName = "Horizontal";
    [Tooltip("Forward direction for object movement.")]
    Vector3 forwardDirection = Vector3.forward;
    
    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        float moveAxis = Input.GetAxisRaw(moveAxisName);
        
        rigidbody.AddForce(forwardDirection * moveAxis * moveSpeed);
    }
}
