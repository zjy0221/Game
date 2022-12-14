using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Loadindown : MonoBehaviour
{
    public Image m_Image;
    public Text m_Text;
   
    float m_CurProgressValue = 0; 
    float m_ProgressValue = 100;

    void Update()
    {
        if (m_CurProgressValue < m_ProgressValue)
        {
            m_CurProgressValue++;
        }
        
        m_Text.text = m_CurProgressValue + "%";
        
        m_Image.GetComponent<Image>().fillAmount = m_CurProgressValue / 100f;
        if (m_CurProgressValue == 100)
        {
            m_Text.text = "100%";
            SceneManager.LoadScene("一樓");
      
        }

        

    }
}

