using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 雪花測試 : MonoBehaviour
{
    
  public GameObject  an;
  

  
    
    void Awake()
    {
      
      an.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
         
       if (Input.GetKeyDown("space"))
      {
        an.SetActive(true);
        Debug.Log("owo???????");
        
      } 
      else
      { 
        an.SetActive(false);
      }

      
    }
}
