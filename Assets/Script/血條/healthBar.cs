using System.Collections;

using System.Collections.Generic;

using UnityEngine;

 

public class healthBar : MonoBehaviour {

    //血量設定

    public const int maxHealth = 100;

    public int currentHealth = maxHealth;

    //血量條

    public RectTransform HealthBar;
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        currentHealth = currentHealth - 10;
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        
    }

    void Update()

    {

    

        //將血條同步到當前血量長度

        HealthBar.sizeDelta = new Vector2(currentHealth, HealthBar.sizeDelta.y);
    
        

    }

}
