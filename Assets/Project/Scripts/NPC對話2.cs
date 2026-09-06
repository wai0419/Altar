using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NPC對話2 : MonoBehaviour
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
    public Sprite 修女長, 金修女, 紅修女, 金護士, 粉護士;

    bool textFinished;//是否打完字
    bool cancelTyping;//取消打字

    public GameObject 丟下位置;
    public GameObject 第一本書;
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
            GameObject DD = Instantiate(第一本書, 丟下位置.transform.position, 丟下位置.transform.rotation);
            Rigidbody rig = DD.GetComponent<Rigidbody>();

            rig.AddForce(丟下位置.transform.forward * 3, ForceMode.Impulse);
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
        //紅修女
        //金修女
        
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
                faceImage.sprite = 金修女;

                break;
            case 7:
                faceImage.sprite = 紅修女;

                break;
            case 8:
                faceImage.sprite = 金修女;

                break;
            case 9:
                faceImage.sprite = 紅修女;

                break;
            case 10:
                faceImage.sprite = 金修女;
                break;


            //修女長
            case 11:
                faceImage.sprite = 修女長;
                break;
            case 12:
                faceImage.sprite = 金修女;
                break;
            case 13:
                faceImage.sprite = 修女長;
                break;
            case 14:
                faceImage.sprite = 金修女;

                break;
            case 15:
                faceImage.sprite = 修女長;

                break;
            case 16:
                faceImage.sprite = 金修女;

                break;
            case 17:
                faceImage.sprite = 修女長;

                break;
            case 18:
                faceImage.sprite = 金修女;

                break;
            case 19:
                faceImage.sprite = 修女長;

                break;
            case 20:
                faceImage.sprite = 金修女;

                break;
            case 21:
                faceImage.sprite = 修女長;

                break;
            case 22:
                faceImage.sprite = 金修女;

                break;
            case 23:
                faceImage.sprite = 金修女;

                break;
            case 24:
                faceImage.sprite = 修女長;
                break;
            case 25:
                faceImage.sprite = 金修女;
                break;




            case 26:
                faceImage.gameObject.SetActive(false);
                
                break;
            case 27:
                faceImage.gameObject.SetActive(true);
                faceImage.sprite = 金修女;
                break;
            case 28:
                faceImage.sprite = 粉護士;

                break;
            case 29:
                faceImage.sprite = 金修女;

                break;
            case 30:
                faceImage.sprite = 粉護士;

                break;
            case 31:
                faceImage.sprite = 金修女;

                break;
            case 32:
                faceImage.sprite = 粉護士;

                break;
            case 33:
                faceImage.sprite = 金修女;

                break;
            case 34:
                faceImage.sprite = 粉護士;

                break;
            case 35:
                faceImage.sprite = 金修女;

                break;
            case 36:

                faceImage.gameObject.SetActive(false);
                break;
            case 37:
                faceImage.gameObject.SetActive(true);
                faceImage.sprite = 粉護士;

                break;
            case 38:
                faceImage.sprite = 金護士;
                break;
            case 39:
                faceImage.sprite = 粉護士;
                break;
            case 40:
                faceImage.sprite = 金護士;
                break;
            case 41:
                faceImage.sprite = 粉護士;
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
