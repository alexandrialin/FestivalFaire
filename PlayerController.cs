using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    float speed = 4f;
    float rotSpeed = 80;
    float gravity = 8;
    Animator anim;
    // Start is called before the first frame update
    Vector3 moveDir = Vector3.zero;
    CharacterController controller;
    void Start()
    {
        controller = GetComponent<CharacterController>();
        anim = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        if (controller.isGrounded)
        {
            if (Input.GetKey(KeyCode.UpArrow))
            {
                moveDir = new Vector3(0, 0, .5f);
                moveDir *= speed;


            }
            if (Input.GetKeyUp(KeyCode.UpArrow))
            {
                moveDir = new Vector3(0, 0, 0);

            }
            if (Input.GetKey(KeyCode.DownArrow))
            {

                moveDir = new Vector3(0, 0, -.5f);
                moveDir *= speed;


            }
            if (Input.GetKeyUp(KeyCode.DownArrow))
            {
                moveDir = new Vector3(0, 0, 0);

            }
            if (Input.GetKey(KeyCode.RightArrow))
            {

                moveDir = new Vector3(.5f, 0, 0);
                moveDir *= speed;


            }
            if (Input.GetKeyUp(KeyCode.RightArrow))
            {

                moveDir = new Vector3(0, 0, 0);

            }
            if (Input.GetKey(KeyCode.LeftArrow))
            {

                moveDir = new Vector3(-.5f, 0, 0);
                moveDir *= speed;


            }
            if (Input.GetKeyUp(KeyCode.LeftArrow))
            {


                moveDir = new Vector3(0, 0, 0);
            }

           
        }
        moveDir.y -= gravity * Time.deltaTime;
        controller.Move(moveDir * Time.deltaTime);

    }
}

