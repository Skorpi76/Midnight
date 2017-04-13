using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    private int speed;
    //  public bool androidInput;
    private Vector3 input;
    private Rigidbody2D rb;
    private Camera playerCamera;

    bool isMoving;

    Animator anim;


    private Vector2 playerToMouse;
    private float angle;
    // ===================================
    void Start()
    {
        speed = 5;
        rb = GetComponent<Rigidbody2D>();
        input = Vector3.zero;
        playerCamera = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();

        anim = GetComponent<Animator>();

    }

    // ===================================
    void Update()
    {
       

       

            input.Set(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
            playerToMouse = transform.position - playerCamera.ScreenToWorldPoint(Input.mousePosition);
            angle = (Mathf.Atan2(playerToMouse.y, playerToMouse.x) * Mathf.Rad2Deg) + 90;
            transform.rotation = Quaternion.Euler(0, 0, angle);
      
        float inputLength = Vector2.Distance(Vector2.zero, new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")));
        if (inputLength > 0)
        {
            isMoving = true;
        }
        else {
            isMoving = false; 
        }
        anim.SetBool("isMoving", isMoving);
    }

    // ===================================
    void FixedUpdate()
    {
        rb.velocity = input * speed;
    }
}





// do not remove pls 


//void Update()
//{
//    input.Set(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);

//    if (androidInput)
//    {
//        if (input != Vector3.zero)
//        {
//            if (input.y != 0)
//            {
//                if (input.y > 0)
//                {
//                    transform.rotation = Quaternion.identity;
//                }
//                else if (input.y < 0)
//                {
//                    transform.rotation = Quaternion.Euler(0, 0, 180);
//                }
//            }
//            else if (input.x != 0)
//            {
//                if (input.x > 0)
//                {
//                    transform.rotation = Quaternion.Euler(0, 0, 270);
//                }
//                else if (input.x < 0)
//                {
//                    transform.rotation = Quaternion.Euler(0, 0, 90);
//                }
//            }

//        }
//    }
//    else
//    {
//        playerToMouse = transform.position - playerCamera.ScreenToWorldPoint(Input.mousePosition);
//        angle = (Mathf.Atan2(playerToMouse.y, playerToMouse.x) * Mathf.Rad2Deg) + 90;
//        transform.rotation = Quaternion.Euler(0, 0, angle);
//    }


//}