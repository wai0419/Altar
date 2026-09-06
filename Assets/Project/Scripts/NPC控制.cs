using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC控制 : MonoBehaviour
{
    public GameObject 提示;

    public GameObject 對話一;

    public GameObject 對話二;

    public GameObject 對話三;

    public GameObject 對話四;

    public GameObject 開頭對話;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(儲存空間.對話段);
        if (第三關儲存空間.開頭對話 == true)
        {
            開頭對話.SetActive(true);
            第三關儲存空間.開頭對話 = false;
        }
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void 顯示提示()
    {
            提示.SetActive(true);
    }
    public void 提示消失()
    {
            提示.SetActive(false);
        
    }
    public void 開啟對話()
    {
        if (儲存空間.對話段 == 1)
        {
            對話一.SetActive(true);
        }
        if (儲存空間.對話段 == 2)
        {
            對話二.SetActive(true);
        }
        if (儲存空間.對話段 == 3)
        {
            對話三.SetActive(true);
        }
        if (儲存空間.對話段 == 4)
        {
            對話四.SetActive(true);
            第三關儲存空間.開頭對話 = true;
        }
    }
}
