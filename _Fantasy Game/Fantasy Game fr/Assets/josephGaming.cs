using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class josephGaming : MonoBehaviour
{
    // Joseph do what joseph pleases
    // i stole this entire thing from https://www.youtube.com/watch?v=f473C43s8nE so if something is broken its jeffrey's fault

    public float sensX, sensY;
    public Transform orientation, camrea;
    float xRotation, yRotation;

    public float moveSpeed;
    float horizontalInput, verticalInput;
    Vector3 moveDirection;
    Rigidbody rb;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;

        //VERY IMPORTANT!!! DONT REMOVE
        gaming(69);
    }

    void Update()
    {
        float mouseX = Input.GetAxisRaw("Mouse X") * Time.deltaTime * sensX;
        float mouseY = Input.GetAxisRaw("Mouse Y") * Time.deltaTime * sensY;

        yRotation += mouseX;
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        camrea.rotation = Quaternion.Euler(xRotation, yRotation, 0); //move camera
        orientation.rotation = Quaternion.Euler(0, yRotation, 0); //rotate player


        horizontalInput = Input.GetAxisRaw("Horizontal");
        verticalInput = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    {
        moveDirection = orientation.forward * verticalInput + orientation.right * horizontalInput;
        rb.AddForce(moveDirection.normalized * moveSpeed, ForceMode.Force);
    }

    void gaming(int k)
    {
        if (k>0)
        {
            gaming(k - 1);
        }
        else
        {
            Debug.Log("schmingus");
        }
    }
}
