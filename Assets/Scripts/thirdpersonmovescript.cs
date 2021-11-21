using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class thirdpersonmovescript : MonoBehaviour
{
    public CharacterController controller;
    public Transform groundCheck;
    public Transform childCam;
    public LayerMask groundMask;

    public float groundDistance = 0.4f;
    public Transform cam;
    public Joystick joystick;
    public Joystick pickUp;

    
    //public bool is3rdPerson = true;
    public static bool isGrabbing;
    Vector3 moveDir;

    float horizontal;
    float vertical;
    public float speed = 6f;
    public float gravity = -9.81f;

    Vector3 velocity;
    public Vector3 camOffset;
    public float turnSmoothTime = 0.1f;
    public float turnSmoothVelocity = 0.01f;
    bool isGrounded;

    // Update is called once per frame
    void Update()
    {
        cam.position = transform.position + camOffset;

        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if(isGrounded && velocity.y < 0){
            velocity.y = -1f;
        }

        if(PersistanceManager.instance.useJoystick == true){
            horizontal = joystick.Horizontal;
            vertical = joystick.Vertical;
            if(pickUp.Horizontal != 0f || pickUp.Vertical != 0f){
                PersistanceManager.instance.grabObject = !PersistanceManager.instance.grabObject;
            }
        }
        if(PersistanceManager.instance.useJoystick == false){
            horizontal = Input.GetAxisRaw("Horizontal");
            vertical = Input.GetAxisRaw("Vertical");
        }        

        Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized;

        if (direction.magnitude >= 0.1f)
        {
            float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg + cam.eulerAngles.y;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, turnSmoothTime);
            transform.rotation = Quaternion.Euler(0f, angle, 0f);

            moveDir = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;
            
            velocity.y += gravity * Time.deltaTime;

            controller.Move(velocity * Time.deltaTime);
    
            controller.Move(moveDir.normalized * speed * Time.deltaTime);
        }                
    }
}
