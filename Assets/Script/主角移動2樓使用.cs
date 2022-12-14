using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 主角移動2樓使用 : MonoBehaviour
{   
    public float speed = 2;
    private Rigidbody2D myRigidbody;
    private float input_x, input_y;
    private float move = 0;
    public Animator animator;
    
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();
    }
    
    void Update()
    {
            input_x = Input.GetAxisRaw("Horizontal");
            input_y = Input.GetAxisRaw("Vertical");
  
            animator.SetFloat("Horizontal",input_x);
            animator.SetFloat("Vertical",input_y);   


            if (input_x != 0 || input_y != 0)
            {
                move = 1;
                animator.SetFloat("Speed", move);
                
            }      
            else 
            {
                move = 0;
                animator.SetFloat("Speed", move);
            }
 
        
    }
    void FixedUpdate()
    {
        myRigidbody.velocity = new Vector2(speed *input_x, speed * input_y);
    }


}