using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class test : MonoBehaviour
{
    public FadeInOut m_Fade;
    public GameObject Dialogue2;

    void Update()
    {

        

        

       if (m_Fade == true&&Input.GetKeyDown(KeyCode.P))
        {
            m_Fade.BackGroundControl(false);
        }
    }


}
