using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class 第一關開始對話 : MonoBehaviour
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
    public Sprite  金修女, 紅修女;

    bool textFinished;//是否打完字
    bool cancelTyping;//取消打字

    public GameObject 提示1;
    public GameObject 提示2;

    public GameObject 時間;

    public GameObject 生成;


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
            時間.SetActive(true);
            生成.SetActive(true);
            this.gameObject.SetActive(false);
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
            case 0:
                faceImage.sprite = 金修女;

                break;
            case 1:
                faceImage.sprite = 紅修女;

                break;
            case 2:
                faceImage.sprite = 金修女;

                break;
            case 3:
                faceImage.sprite = 紅修女;

                break;
            case 4:
                faceImage.sprite = 金修女;

                break;
            case 5:
                faceImage.sprite = 紅修女;

                break;
            case 6:
                faceImage.gameObject.SetActive(false);
                提示1.SetActive(true);
                break;
            case 7:
                faceImage.gameObject.SetActive(false);
                提示2.SetActive(true);
                break;
            case 8:
                faceImage.gameObject.SetActive(true);
                提示1.SetActive(false);
                提示2.SetActive(false);
                faceImage.sprite = 紅修女;

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
