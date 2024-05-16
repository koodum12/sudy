using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    public BoxCollider2D boxCollider;
    public Rigidbody2D rigid2D;
    
    
    public float moveSpeed;
    public float jumpPower;
    private Vector2 vec2;

    public int jumpCount;
    public int jumpCountTemp;
    private bool isGround;

    void Start()
    {
        boxCollider = GetComponent<BoxCollider2D>();
        rigid2D = GetComponent<Rigidbody2D>();
    }

    private void Awake()
    {
        jumpCountTemp = jumpCount;
    }

    private void FixedUpdate()
    {
        
    }

    private void Update()
    {
        Move();
        JumpTry();
        IsGround();
    }

    private void IsGround()
    {
        isGround = Physics.Raycast(transform.position, Vector2.down,boxCollider.bounds.extents.y + 0.1f);
        
    }

    void Move()
    {
        Vector3 moveVelocity = Vector3.zero;
        if (Input.GetAxisRaw("Horizontal") > 0)
        {
            moveVelocity = Vector3.right;
        }
        if (Input.GetAxisRaw("Horizontal") < 0)
        {
            moveVelocity = Vector3.left;
        }

        transform.position += moveVelocity *(moveSpeed * Time.deltaTime);
    }

    void JumpTry()
    {
        if (isGround == true)
        {
            jumpCount = jumpCountTemp;
        }
        
        if (Input.GetKeyUp(KeyCode.Space)&&jumpCount!=0)
        {
            jumpCount--;
            Debug.Log(jumpCount);
            Jump();
        }
            
    }

    void Jump()
    {
        rigid2D.AddForce(new Vector2(0,jumpPower),ForceMode2D.Force);
    }

}
