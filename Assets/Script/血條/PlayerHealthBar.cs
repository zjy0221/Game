using System.Collections;

using System.Collections.Generic;

using UnityEngine;

 

public class PlayerHealthBar : MonoBehaviour {

    //血量設定

    public const int maxHealth = 100;

    public int currentHealth = maxHealth;

    //血量條

    public RectTransform HealthBar;
    public RectTransform Endurance;
    

    void Update()

    {

        //按下H鈕扣血

        if (Input.GetKeyDown(KeyCode.H))

        {

        //接受傷害

            currentHealth = currentHealth - 10;

        }

        //將血條同步到當前血量長度

        HealthBar.sizeDelta = new Vector2(currentHealth, HealthBar.sizeDelta.y);
        Endurance.sizeDelta = new Vector2(currentHealth, Endurance.sizeDelta.y);
        


        

    }

}
