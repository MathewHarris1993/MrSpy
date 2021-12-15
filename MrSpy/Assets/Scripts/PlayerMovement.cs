using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Numerics;
using Unity.VisualScripting;
using UnityEngine;
using Vector3 = UnityEngine.Vector3;

public class PlayerMovement : MonoBehaviour
{
    Animator pAnimator;
    private Rigidbody pRB;
    Vector3 movement;
    public float rSpeed = 20f;
    


    void Start()
    {
        pAnimator = GetComponent<Animator>();
        pRB = GetComponent<Rigidbody>();
        

    }

    void FixedUpdate()
    {
        //axis variables set
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        //animation variables set
        bool hasHorizontalInput = !Mathf.Approximately(horizontal, 0f);
        bool hasVerticalInput = !Mathf.Approximately(vertical, 0f);

        //set animation parameters
        bool isWalking = hasHorizontalInput || hasVerticalInput;
        pAnimator.SetBool("isWalking", isWalking);

       transform.Translate(Vector3.forward * vertical * rSpeed * Time.deltaTime);
       transform.Translate(Vector3.right * horizontal * rSpeed * Time.deltaTime);



    }



    
}




