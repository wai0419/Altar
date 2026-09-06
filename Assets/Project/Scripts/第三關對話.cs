using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class 第三關對話 : MonoBehaviour
{
    //對話第一段
    [Header("UI組件")]
    public Text textLabel;
    public Image faceImage;

    [Header("文本文件")]
    public TextAsset textfile;
    public int index;
    public float textspeed;

    [Header("頭像")]
    public Sprite face1, face2;

    bool textFinished;//是否打完字
    bool cancelTyping;//取消打字

    public GameObject 流程圖;
    public GameObject 流程圖2;
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
            gameObject.SetActive(false);
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

        switch (index)
        {
            case 1:
                faceImage.sprite = face1;

                break;
            case 2:
                faceImage.sprite = face2;

                break;
            case 3:
                faceImage.sprite = face1;

                break;
            case 4:
                faceImage.sprite = face2;

                break;
            case 5:
                faceImage.sprite = face1;

                break;
            case 6:
                faceImage.sprite = face2;

                break;
            case 7:
                faceImage.sprite = face1;

                break;
            case 8:
                faceImage.sprite = face2;

                break;
            case 9:
                faceImage.sprite = null;

                break;
            case 10:
                faceImage.sprite = null;

                break;
            case 11:
                faceImage.sprite = null;
                break;
            case 12:
                faceImage.sprite = null;
                break;
            case 13:
                faceImage.sprite = null;
                break;
            case 14:
                faceImage.sprite = face1;
                break;


        }//對話頭像

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
