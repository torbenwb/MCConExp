using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class InputMover3D : MonoBehaviour
{
    Rigidbody rigidbody;

    public float moveSpeed = 10f;

    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float xInput = Input.GetAxisRaw("Horizontal");
        float yInput = Input.GetAxisRaw("Vertical");

        Vector3 right = Camera.main.transform.right; right.y = 0f;
        Vector3 forward = Camera.main.transform.forward; forward.y = 0f;
        Vector3 moveDirection = (forward.normalized * yInput) + (right.normalized * xInput);
        
        rigidbody.AddForce(moveDirection.normalized * moveSpeed);
    }
}
