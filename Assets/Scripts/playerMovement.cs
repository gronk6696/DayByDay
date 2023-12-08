using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using TMPro;

public class playerControls : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    [SerializeField] private float speedMove = 500;
    [SerializeField] private float speedRotate = 100;


    
    private float forwardInputValue;
    private float backwardInputValue;
    private float rightInputValue;
    private float leftInputValue;
    private float spaceInputValue;

    private Transform objectTransform;

    
    //inputs
    private void OnMoveForward(InputValue value)
    {
        forwardInputValue = value.Get<float>();
        //Debug.Log("Forward Input: " + forwardInputValue);
    }
    private void OnMoveBack(InputValue value)
    {
        backwardInputValue = value.Get<float>();
        //Debug.Log("Backward Input: " + backwardInputValue);
    }
    private void OnTurnRight(InputValue value)
    {
        rightInputValue = value.Get<float>();
    }
    private void OnTurnLeft(InputValue value)
    {
        leftInputValue = value.Get<float>();
    }


    //movement logic
    private void MoveLogicMethod()
    {
        // Calculate movement
        float moveInput = forwardInputValue - backwardInputValue;
       Vector3 moveDirection = transform.forward * moveInput;
        Vector3 result = moveDirection * speedMove * Time.fixedDeltaTime;
        rb.velocity = result;

        //Calculate rotation
        float rotateInput = rightInputValue - leftInputValue;
        Vector3 rotation = new Vector3(0f, rotateInput * speedRotate * Time.fixedDeltaTime, 0f);
        Quaternion newRotation = rb.rotation * Quaternion.Euler(rotation);
        rb.MoveRotation(newRotation);
    }

    private void FixedUpdate()
    {
        MoveLogicMethod();
    }

    void Start()
    {
        objectTransform = transform;
    }

    void Update()
    {
        
    }
}