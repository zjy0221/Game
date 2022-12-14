using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Move1Floor : MonoBehaviour
{
    public GameObject Button;

    private void OnTriggerEnter2D(Collider2D other)
    {
        Button.SetActive(true);
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        Button.SetActive(false);
    }
    private void Update()
    {
        if (Button.activeSelf && Input.GetKeyDown(KeyCode.F))
        {
           SceneManager.LoadScene("加載動畫-下樓");
        }
    }


}
