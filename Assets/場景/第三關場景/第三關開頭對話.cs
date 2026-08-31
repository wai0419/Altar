using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class 第三關開頭對話 : MonoBehaviour
{
    Light light;
    public GameObject 光;

    public GameObject 動畫相機;
    public GameObject 一般相機;

    public GameObject 鏟子聚光燈;

    public GameObject 書本聚光燈;

    public GameObject 土聚光燈;

    public GameObject 生成;

    public GameObject 時間;

    public GameObject 流程圖;

    public GameObject 流程圖2;
    //對話第一段
    [Header("UI組件")]
    public Text textLabel;

    [Header("文本文件")]
    public TextAsset textfile;
    public int index;
    public float textspeed;

    bool textFinished;//是否打完字
    bool cancelTyping;//取消打字
    public bool L1;
    public bool L2;
    public Image 圖片;
    public Sprite 金修女, 紅修女;
    List<string> textList = new List<string>();
    void Start()
    {
        light = 光.GetComponent<Light>();

        //T.text = "歡迎來到第二關";
        L1 = true;

    }
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
        if (L1 == true)
        {
            light.intensity = Mathf.Lerp(light.intensity, 0.5f, 0.03f);
            if (light.intensity < 0.5f)
            {
                L1 = false;
            }
        }
        if (L2 == true)
        {
            light.intensity = Mathf.Lerp(light.intensity, 1.6f, 0.03f);
            if (light.intensity > 1.5f)
            {
                L2 = false;

            }
        }
        if (Input.GetKeyDown(KeyCode.R) && index == textList.Count)
        {
            L2 = true;
            this.gameObject.SetActive(false);
            生成.SetActive(true);
            時間.SetActive(true);
            動畫相機.SetActive(false);
            一般相機.SetActive(true);
            鏟子聚光燈.SetActive(false);
            書本聚光燈.SetActive(false);
            土聚光燈.SetActive(false);
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
            case 4:
                鏟子聚光燈.SetActive(true);
                書本聚光燈.SetActive(false);
                土聚光燈.SetActive(false);
                
                break;
            case 5:
                鏟子聚光燈.SetActive(false);
                書本聚光燈.SetActive(true);
                土聚光燈.SetActive(false);
                break;
            case 7:
                鏟子聚光燈.SetActive(false);
                書本聚光燈.SetActive(false);
                土聚光燈.SetActive(true);
                
                break;
            case 10:
                L2 = true;
                break;
            case 12:
                圖片.gameObject.SetActive(true);
                圖片.sprite = 紅修女;
                L2 = true;
                
                
                break;
            case 13:
                圖片.sprite = 金修女;
                break;
            case 14:
                流程圖.SetActive(true);
                圖片.sprite = 紅修女;
                break;
            case 15:
                流程圖2.SetActive(true);
                流程圖.SetActive(false);
                圖片.sprite = 紅修女;
                break;
            case 16:
                流程圖2.SetActive(false);
                圖片.sprite = 紅修女;
                break;
            case 1:
                圖片.sprite = 金修女;
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
