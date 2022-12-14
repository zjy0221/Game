using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Dialogue2 : MonoBehaviour
{   
    [Header("UI組件")]
    public Text textLabel;
    public Image faceImage;
    public FadeInOut m_Fade;

    [Header("文字腳本2")]
    public TextAsset textFile;
    public int index;
    public float textSpeed;
    public GameObject tip;

    [Header("角色")]
    public Sprite face00,face05;

    bool textFinished;//是否完成打字
    bool cancelTyping;//取消打字

    List<string> textList = new List<string>();
    void Awake()
    {
        GetTextFormFile(textFile); 
    }
    
    private void OnEnable()
    {
        //textLabel.text = textList[index];
        //index++;
        textFinished = true;
        StartCoroutine(SetTextUI());
        
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && index == textList.Count)//文本輸出到最後時
        {
            gameObject.SetActive(false);
            index = 0;

            /*if (Input.GetKeyDown(KeyCode.Space))
            {
                m_Fade.BackGroundControl(true);
            }*/

            return;//關閉文本且歸零
        }
        
        if(Input.GetKeyDown(KeyCode.Space))
        {
            if(textFinished && !cancelTyping)
            {
                StartCoroutine(SetTextUI());
            }
            else if(!textFinished && !cancelTyping)
            {
                cancelTyping = true;
            }
        }

        if(index == 2)
        {
            tip.SetActive(true);
        }
        else
        {
            tip.SetActive(false);
        }

      

    }

    void GetTextFormFile(TextAsset file)
    {
        textList.Clear();
        index = 0;
        var lineDate = file.text.Split('\n');

        foreach(var line in lineDate)
        {
            textList.Add(line);
        }
    }

    IEnumerator SetTextUI()
    {
        textFinished = false; //代表正在輸出
        textLabel.text = "";

        switch (textList[index].Trim().ToString())

        {

            case "A":

                faceImage.sprite = face00;

                index++;

                break;

            case "B":

                faceImage.sprite = face05;

                index++;

                break;

            

            

        }

        /*for(int i=0; i<textList[index].Length; i++ )
        {
            textLabel.text  += textList[index][i];

            yield return new WaitForSeconds(textSpeed);
        }*/

        int letter = 0;
        while(!cancelTyping && letter < textList[index].Length-1)
        {
            textLabel.text += textList[index][letter];
            letter++;
            yield return new WaitForSeconds(textSpeed);//等待
        }
        textLabel.text = textList[index];
        cancelTyping = false;
        textFinished = true;//判斷我的文字輸出完畢
        index++;


    }

}
