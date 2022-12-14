using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 主角移動1樓使用 : MonoBehaviour
{   
    public float speed = 2;
    private Rigidbody2D myRigidbody;
    private float input_x, input_y;
    private float move = 0;
    private float stand = 0;
    public Animator animator;
    public GameObject Button;//顯示提示F按鍵
    
    

    public bool isStand = false;
    

    void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        if(stand == 0){   

            if (Input.GetKeyDown(KeyCode.F))
            {
            
             stand = 1;
             transform.position = new Vector2(-0.943f , -0.5f);
             animator.SetFloat("Stand", stand);
             isStand = true;
            
            }
             

 

        }

        
   
        if(isStand != false){
        
        
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
        
        
    }
   private void FixedUpdate()
    {
        myRigidbody.velocity = new Vector2(speed *input_x, speed * input_y);
    }


}