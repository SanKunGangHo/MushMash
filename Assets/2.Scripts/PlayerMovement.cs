using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float walkSpeed = 10f;
    private Vector2 moveInput;
    private Rigidbody rigidBody;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Run();
    }

    void Run(){
        Vector3 playerVelocity = new Vector3(moveInput.x*walkSpeed, rigidBody.velocity.y, moveInput.y*walkSpeed);
        rigidBody.velocity = transform.TransformDirection(playerVelocity);
    }
    
    public void OnMove(InputValue value){
        moveInput = value.Get<Vector2>();
    }

    
}
