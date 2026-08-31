using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class 對話 : MonoBehaviour
{
    public AudioSource 完成聲;
    //public GameObject TextMeshPro;
    public TMP_Text T;
    public TextAsset TF;

    public GameObject 光;

    public GameObject 動畫相機;
    public GameObject 一般相機;

    Light light;

    public int index;

    List<string> textlist = new List<string>();

    public float textspeed;

    bool textfile;

    public GameObject 鋸子聚光燈;

    public GameObject 針聚光燈;

    public GameObject 繃帶聚光燈;

    public GameObject AED聚光燈;

    public GameObject 福馬林聚光燈;

    public GameObject 生成;

    public GameObject 時間;

    public Sprite 金護士, 粉護士;

    public Image 圖片;
    public bool L1;
    public bool L2;

    public GameObject 流程圖;

    public GameObject 流程圖2;
    void Start()
    {
        if (!完成聲.isPlaying)
        {
            完成聲.Play();
        }
        light = 光.GetComponent<Light>();

        //T.text = "歡迎來到第二關";
        L1 = true;
    }
    void Awake()
    {
        GetTextFormFile(TF);
        index = 0;
    }
    private void OnEnable()
    {
        textfile = true;
        
        StartCoroutine(SetTextUI());
    }
    
    void Update()
    {
        if(L1==true)
        {
            light.intensity = Mathf.Lerp(light.intensity, 0.1f, 0.03f);
            if (light.intensity<0.11f)
            {
                L1 = false;
            }
        }
        if (L2 == true)
        {
            light.intensity = Mathf.Lerp(light.intensity, 0.7f, 0.03f);
            if (light.intensity > 0.68f)
            {
                L2 = false;
                
            }
        }
        if (index == 1)
        {
            T.text = "歡迎來到第二關(按R繼續對話)";
        }

        if (index == 2)
        {
            T.text = "這一關跟前一關不一樣";
        }
        if (index == 3)
        {
            T.text = "我們需要先用自身武器擊倒怪物";
        }
        if (index == 4)
        {
            T.text = "再用不同道具來摘除不同怪物身體";
        }

        if (index == 5)
        {
            針聚光燈.SetActive(true);
            鋸子聚光燈.SetActive(false);
            繃帶聚光燈.SetActive(false);
            AED聚光燈.SetActive(false);
            Vector3 D = new Vector3(-1f, 20f, -14f);
            動畫相機.transform.position = Vector3.Lerp(動畫相機.transform.position, D, 0.1f);
            動畫相機.transform.rotation= Quaternion.Euler(new Vector3(0, -125, 0));
            T.text = "這是針用來對付縫合怪物用的";
        }
        if (index == 6)
        {
            T.text = "把它身上縫線全拆除吧";
        }
        if (index == 7)
        {
            針聚光燈.SetActive(false);
            鋸子聚光燈.SetActive(true);
            繃帶聚光燈.SetActive(false);
            AED聚光燈.SetActive(false);
            Vector3 D = new Vector3(-5.77f, 20f, -11f);
            動畫相機.transform.position = Vector3.Lerp(動畫相機.transform.position, D, 0.1f);
            動畫相機.transform.rotation = Quaternion.Euler(new Vector3(0, -300, 0));
            T.text = "看過來這是鋸子用來鋸斷一般病患怪物";
        }

        if (index == 8)
        {
            針聚光燈.SetActive(false);
            鋸子聚光燈.SetActive(false);
            繃帶聚光燈.SetActive(false);
            AED聚光燈.SetActive(true);
            Vector3 D = new Vector3(14.03f, 20f, 16.08f);
            動畫相機.transform.position = Vector3.Lerp(動畫相機.transform.position, D, 0.1f);
            動畫相機.transform.rotation = Quaternion.Euler(new Vector3(0, 29.488f, 0));
            T.text = "這邊是AED電擊器";
        }

        if (index == 9)
        {
            T.text = "用於把那個癲瘋傻逼病患腦袋電融化";
        }
        if (index == 10)
        {
            針聚光燈.SetActive(false);
            鋸子聚光燈.SetActive(false);
            繃帶聚光燈.SetActive(true);
            AED聚光燈.SetActive(false);
            Vector3 D = new Vector3(-5.6f, 20f, 11.94f);
            動畫相機.transform.position = Vector3.Lerp(動畫相機.transform.position, D, 0.1f);
            動畫相機.transform.rotation = Quaternion.Euler(new Vector3(0, -421.48f, 0));
            T.text = "最後是繃帶需要把怪物器官包起來";
        }
        if (index == 11)
        {
            T.text = "丟入中央福馬林中";
        }
        
        if (index == 12)
        {
            針聚光燈.SetActive(false);
            鋸子聚光燈.SetActive(false);
            繃帶聚光燈.SetActive(false);
            AED聚光燈.SetActive(false);
            福馬林聚光燈.SetActive(true);
            T.text = "這就是福馬林泳池";
            Vector3 D = new Vector3(1, 20f, 2f);
            動畫相機.transform.position = Vector3.Lerp(動畫相機.transform.position, D, 0.1f);
            動畫相機.transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
        }
        if (index == 13)
        {
            T.text = "讓怪物們都來泳池玩吧小心各房間陷阱";
        }
        if (index == 14)
        {
            針聚光燈.SetActive(false);
            鋸子聚光燈.SetActive(false);
            繃帶聚光燈.SetActive(false);
            AED聚光燈.SetActive(false);
            福馬林聚光燈.SetActive(false);
            L2 = true;
            T.text = "加油～";
        }
        if (index == 15)
        {
            圖片.gameObject.SetActive(true);
            圖片.sprite = 金護士;
            T.text = "醫院底下竟然有這種奇怪的實驗室，這醫院正常嗎....";
        }
        if (index == 16)
        {
            圖片.sprite = 粉護士;
            T.text = "嘛...這個不是重點啦，這次的敵人比較麻煩，法術看來是不管用了。";
        }
        if (index == 17)
        {
            圖片.sprite = 金護士;
            T.text = "诶!那怎麼辦!";
        }
        if (index == 18)
        {
            圖片.sprite = 粉護士;
            T.text = "我跟妳講一下流程吧。";
        }
        if (index == 19)
        {
            圖片.sprite = 粉護士;
            流程圖.SetActive(true);
            T.text = "<教學介紹>繼續按R";
        }
        if (index == 20)
        {
            圖片.sprite = 粉護士;
            流程圖2.SetActive(true);
            流程圖.SetActive(false);
            T.text = "<教學介紹>繼續按R";
        }
        if (index == 21)
        {
            流程圖2.SetActive(false);
            圖片.sprite = 粉護士;
            T.text = "小心不要踩到陷阱喔!他們來了!";
        }
        if (Input.GetKeyDown(KeyCode.R)&&index==textlist.Count)
        {
            一般相機.SetActive(true);
            動畫相機.SetActive(false);
            生成.SetActive(true);
            時間.SetActive(true);
            light.intensity = 0.7f;
            T.text = "";
            //TextMeshPro.SetActive(false);
            index = 0;
            gameObject.SetActive(false);
            return;
        }
        if (Input.GetKeyDown(KeyCode.R)&& textfile)
        {
            
            StartCoroutine(SetTextUI());
    
        }






    }

    void GetTextFormFile(TextAsset file)
    {
        textlist.Clear();
        index = 0;
        
        var LineDate=file.text.Split('\n');

        foreach(var Line in LineDate)
        {
            textlist.Add(Line);
        }
    }
    IEnumerator SetTextUI()
    {
        textfile = false;
        T.text = "";
        for(int i=0;i<textlist[index].Length;i++)
        {
            T.text += textlist[index][i];

            yield return new WaitForSeconds(textspeed);
        }
        textfile = true;
        index++;
    }
}

