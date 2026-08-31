using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NPC對話3 : MonoBehaviour
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
    public GameObject 第三本書;
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

            GameObject DD = Instantiate(第三本書, 丟下位置.transform.position, 丟下位置.transform.rotation);
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
        textFinished = false;
        textLabel.text = "";

        switch (index)
        {
            case 0:
                faceImage.sprite = 金護士;

                break;
            case 1:
                faceImage.sprite = 金護士;

                break;
            case 2:
                faceImage.sprite = 金護士;

                break;
            case 3:
                faceImage.sprite = 金護士;

                break;
            case 4:
                faceImage.sprite = 粉護士;

                break;
            case 5:
                faceImage.sprite = 金護士;

                break;




            case 6:
                faceImage.sprite = 修女長;

                break;
            case 7:
                faceImage.sprite = 金修女;

                break;
            case 8:
                faceImage.sprite = 修女長;

                break;
            case 9:
                faceImage.sprite = 金修女;

                break;
            case 10:
                faceImage.sprite = 修女長;
                break;
            case 11:
                faceImage.sprite = 金修女;
                break;
            case 12:
                faceImage.sprite = 修女長;
                break;
            case 13:
                faceImage.sprite = 修女長;
                break;
            case 14:
                faceImage.sprite = 修女長;

                break;
            case 15:
                faceImage.sprite = 金修女;

                break;
            case 16:
                faceImage.sprite = 修女長;

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
