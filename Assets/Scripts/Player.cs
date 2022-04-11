using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public CharacterController controller;
    private Vector3 movement;
    private Vector3 direction;

    public float speed= 2.5f;
    public int points = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
        //Debug.Log(Input.GetAxis("Horizontal"));
        movement.x = Input.GetAxis("Horizontal");
        movement.z = Input.GetAxis("Vertical");

        direction = movement;
        direction.y = 0f;

        if (direction.magnitude > 0f)
        {
            transform.rotation = Quaternion.LookRotation(direction, Vector3.up);
        }

        if (controller.isGrounded)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                movement.y = 2.5f;
            }
           
        }
        else
        {
             movement.y -= 0.01f;
        }
        
    }
    void FixedUpdate()
    {
        controller.Move(movement * Time.fixedDeltaTime * speed);
        
    }
}
