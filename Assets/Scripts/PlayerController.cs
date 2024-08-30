using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public static PlayerController instance;
    public float speed;
    public float strafeSpeed;
    public float jumpforce;
    public float rotationSpeed = 1;

    float mouseX, mouseY;

    public float headOffset;

    public ConfigurableJoint bodyJoint,headJoint;

    public Rigidbody body;
    public bool isGrounded;
    public GameObject selectedObject;

    void Start()
    {
        if(instance == null)
        {
            instance = this;
        }else if(instance != this)
        {
            Destroy(this);
        }
        //Cursor.lockState = CursorLockMode.Locked;   
        body = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        
        if(Input.GetKey(KeyCode.W))
        {
            if(Input.GetKey (KeyCode.LeftShift)) 
            {
                body.AddForce(body.transform.forward * speed * 1.5f);
            }
            else
            {
                body.AddForce(body.transform.forward * speed);
            }
        }
        if (Input.GetKey(KeyCode.A))
        {
            body.AddForce(-body.transform.right * strafeSpeed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            body.AddForce(-body.transform.forward * strafeSpeed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            body.AddForce(body.transform.right * strafeSpeed);
        }

        mouseX += Input.GetAxis("Mouse X") * rotationSpeed;
        mouseY -= Input.GetAxis("Mouse Y") * rotationSpeed;
        mouseY = Mathf.Clamp(mouseY, -35, 60);

        bodyJoint.targetRotation = Quaternion.Euler(0, -mouseX, 0);
        /*headJoint.targetRotation = Quaternion.Euler(0, -mouseX - headOffset, 0);*/
    }
}
