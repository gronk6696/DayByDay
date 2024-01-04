using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameSortPaddle : MonoBehaviour
{
    public Rigidbody rb;
    public float speedRotate = 5;
    private bool isRotating = false;

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            isRotating = true;
        }
        else
        {
            isRotating = false;
        }

        if (isRotating)
        {
            rb.transform.Rotate(Vector3.forward * speedRotate * Time.fixedDeltaTime);
        }
        else
        {
            rb.transform.Rotate(-Vector3.forward * speedRotate * Time.fixedDeltaTime);
        }
    }
}
