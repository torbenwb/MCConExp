using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class InputJumper : MonoBehaviour
{
    Rigidbody rigidbody;
    
    [Tooltip("How strong this object's jump should be.")]
    public float jumpStrength = 10f;
    [Tooltip("Name of button to press to jump")]
    public string buttonName = "Jump";
    [Tooltip("Jump up in local or global coordinate space")]
    public Space jumpCoordinateSpace = Space.Self;

    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody>();
    }
    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown(buttonName)) {
            switch(jumpCoordinateSpace){
                case Space.World: rigidbody.AddForce(Vector3.up * jumpStrength, ForceMode.Impulse);
                    break;
                case Space.Self: rigidbody.AddForce(rigidbody.transform.up * jumpStrength, ForceMode.Impulse);  
                    break;
            }
             
        }
    }
}
