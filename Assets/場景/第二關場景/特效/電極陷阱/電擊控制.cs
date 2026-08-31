using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 電擊控制 : MonoBehaviour
{
    public GameObject 電擊關閉1;
    public GameObject 電擊關閉2;
    public GameObject 電擊關閉3;
    public GameObject 電擊關閉4;

    public GameObject 電擊開啟1;
    public GameObject 電擊開啟2;
    public GameObject 電擊開啟3;
    public GameObject 電擊開啟4;

    public int i = 0;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("選擇", 2);

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void 選擇()
    {
        i = Random.Range(1, 14);
        
        var 電擊1 = 電擊開啟1.GetComponent<電極>();

        var 電擊2 = 電擊開啟2.GetComponent<電極>();

        var 電擊3 = 電擊開啟3.GetComponent<電極>();

        var 電擊4 = 電擊開啟4.GetComponent<電極>();
        
        switch (i)
        {
            case 1:
                電擊關閉1.SetActive(false);
                電擊開啟1.SetActive(true);
                電擊1.開啟 = true;
                Invoke("回復", 12);
                break;
            case 2:
                電擊關閉2.SetActive(false);
                電擊開啟2.SetActive(true);
                電擊2.開啟 = true;
                Invoke("回復", 12);
                break;
            case 3:
                電擊關閉3.SetActive(false);
                電擊開啟3.SetActive(true);
                電擊3.開啟 = true;
                Invoke("回復", 12);
                break;
            case 4:
                電擊關閉4.SetActive(false);
                電擊開啟4.SetActive(true);
                電擊4.開啟 = true;
                Invoke("回復", 12);
                break;
            case 5:
                電擊關閉1.SetActive(false);
                電擊開啟1.SetActive(true);
                電擊關閉2.SetActive(false);
                電擊開啟2.SetActive(true);
                電擊1.開啟 = true;
                電擊2.開啟 = true;
                Invoke("回復", 12);
                break;
            case 6:
                電擊關閉1.SetActive(false);
                電擊開啟1.SetActive(true);
                電擊關閉3.SetActive(false);
                電擊開啟3.SetActive(true);
                電擊1.開啟 = true;
                電擊3.開啟 = true;
                Invoke("回復", 12);
                break;
            case 7:
                電擊關閉1.SetActive(false);
                電擊開啟1.SetActive(true);
                電擊關閉4.SetActive(false);
                電擊開啟4.SetActive(true);
                電擊1.開啟 = true;
                電擊4.開啟 = true;
                Invoke("回復", 12);
                break;
            case 8:
                電擊關閉2.SetActive(false);
                電擊開啟2.SetActive(true);
                電擊關閉3.SetActive(false);
                電擊開啟3.SetActive(true);
                電擊2.開啟 = true;
                電擊3.開啟 = true;
                Invoke("回復", 12);
                break;
            case 9:
                電擊關閉2.SetActive(false);
                電擊開啟2.SetActive(true);
                電擊關閉4.SetActive(false);
                電擊開啟4.SetActive(true);
                電擊2.開啟 = true;
                電擊4.開啟 = true;
                Invoke("回復", 12);
                break;
            case 10:
                電擊關閉1.SetActive(false);
                電擊開啟1.SetActive(true);
                電擊關閉2.SetActive(false);
                電擊開啟2.SetActive(true);
                電擊關閉3.SetActive(false);
                電擊開啟3.SetActive(true);
                電擊1.開啟 = true;
                電擊2.開啟 = true;
                電擊3.開啟 = true;
                Invoke("回復", 12);
                break;
            case 11:
                電擊關閉2.SetActive(false);
                電擊開啟2.SetActive(true);
                電擊關閉3.SetActive(false);
                電擊開啟3.SetActive(true);
                電擊關閉4.SetActive(false);
                電擊開啟4.SetActive(true);
                電擊2.開啟 = true;
                電擊3.開啟 = true;
                電擊4.開啟 = true;
                Invoke("回復", 12);
                break;
            case 12:
                電擊關閉1.SetActive(false);
                電擊開啟1.SetActive(true);
                電擊關閉3.SetActive(false);
                電擊開啟3.SetActive(true);
                電擊關閉4.SetActive(false);
                電擊開啟4.SetActive(true);
                電擊1.開啟 = true;
                電擊3.開啟 = true;
                電擊4.開啟 = true;
                Invoke("回復", 12);
                break;
            case 13:
                電擊關閉1.SetActive(false);
                電擊開啟1.SetActive(true);
                電擊關閉2.SetActive(false);
                電擊開啟2.SetActive(true);
                電擊關閉3.SetActive(false);
                電擊開啟3.SetActive(true);
                電擊關閉4.SetActive(false);
                電擊開啟4.SetActive(true);
                電擊1.開啟 = true;
                電擊2.開啟 = true;
                電擊3.開啟 = true;
                電擊4.開啟 = true;
                Invoke("回復", 12);
                break;
        }
    }
    void 回復()
    {
        電擊關閉1.SetActive(true);
        電擊開啟1.SetActive(false);

        電擊關閉2.SetActive(true);
        電擊開啟2.SetActive(false);

        電擊關閉3.SetActive(true);
        電擊開啟3.SetActive(false);

        電擊關閉4.SetActive(true);
        電擊開啟4.SetActive(false);

        Invoke("重新", 5);
    }
    void 重新()
    {
        選擇();
    }
}
