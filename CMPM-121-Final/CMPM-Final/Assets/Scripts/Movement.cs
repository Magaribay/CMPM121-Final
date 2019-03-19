using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public static float moveSpeed;
    public float jumpForce;
    public CharacterController controller;
    //public Rigidbody rb;

    private Vector3 moveDirection;
    public bool facingRight = true;
    public float gravityScale; 

    // Start is called before the first frame update
    void Start()
    {
        moveSpeed = 10;
        controller = GetComponent<CharacterController>();
        Debug.Log("Current Speed:" + moveSpeed);
    }

    // Update is called once per frame
    void Update()
    {

        moveDirection = new Vector3(Input.GetAxis("Horizontal") * moveSpeed, moveDirection.y, 0f);


        if (Input.GetAxis("Horizontal") > 0 && !facingRight)
            Flip();
        else if (Input.GetAxis("Horizontal") < 0 && facingRight)
            Flip();


        if (controller.isGrounded)
        {

            if (Input.GetButtonDown("Jump"))
            {
                moveDirection.y = jumpForce;
            }
        }

        moveDirection.y = moveDirection.y + (Physics.gravity.y * gravityScale * Time.deltaTime);

        controller.Move(moveDirection* Time.deltaTime);
    }

    public void SetSlowSpeed()
    {
        moveSpeed = 5;
        Debug.Log(moveSpeed);
    }

    public void ResetSpeed()
    {
        moveSpeed = 10;
        Debug.Log("Speed back to:" + moveSpeed);
    }

    void Flip()
    {
        facingRight = !facingRight;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }

}


