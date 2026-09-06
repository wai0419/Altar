using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class 一開始對話 : MonoBehaviour
{
    
    //對話第一段
    [Header("UI組件")]
    public Text textLabel;
    public Image faceImage;

    [Header("文本文件")]
    public TextAsset textfile;
    public int index;
    public float textspeed;

    bool textFinished;//是否打完字
    bool cancelTyping;//取消打字


    public GameObject 黑屏;
    List<string> textList = new List<string>();

    void Awake()
    {
        GetTextFormFile(textfile);

    }
    private void OnEnable()
    {

        StartCoroutine(SetTextUI());
        textFinished = true;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R) && index == textList.Count)
        {
            this.gameObject.SetActive(false);
            黑屏.SetActive(false);
            index = 0;
            return;
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            if (textFinished && !cancelTyping)
            {
                StartCoroutine(SetTextUI());
            }
            else if (!textFinished && !cancelTyping)
            {
                cancelTyping = true;
            }
        }


    }
    void GetTextFormFile(TextAsset file)
    {
        textList.Clear();
        index = 0;

        var linedate = file.text.Split('\n');

        foreach (var line in linedate)
        {
            textList.Add(line);
        }
    }

    IEnumerator SetTextUI()
    {
        textFinished = false;
        textLabel.text = "";

        int letter = 0;
        while (!cancelTyping && letter < textList[index].Length - 1)
        {
            textLabel.text += textList[index][letter];
            letter++;
            yield return new WaitForSeconds(textspeed);
        }
        textLabel.text = textList[index];
        cancelTyping = false;

        textFinished = true;
        index++;
    }
}
