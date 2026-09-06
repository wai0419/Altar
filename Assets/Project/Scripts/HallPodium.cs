using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HallPodium : MonoBehaviour
{
    //大廳講座
    public GameObject 第一關;
    public GameObject 第二關;
    public GameObject 第三關;

    public GameObject 第一關特效;
    public GameObject 第二關特效;
    public GameObject 第三關特效;

    public GameObject 跳轉放大;

    void Start()
    {
        跳轉放大.SetActive(true);
        Destroy(跳轉放大, 5);
    }
    public void 顯示第一關()
    {
        第一關.SetActive(true);
        第一關特效.SetActive(true);
    }
    public void 顯示第二關()
    {
        第二關.SetActive(true);
        第二關特效.SetActive(true);
    }

    public void 顯示第三關()
    {
        第三關.SetActive(true);
        第三關特效.SetActive(true);
    }

    public void 消失第一關()
    {
        第一關.SetActive(false);
        第一關特效.SetActive(false);
    }
    public void 消失第二關()
    {
        第二關.SetActive(false);
        第二關特效.SetActive(false);
    }

    public void 消失第三關()
    {
        第三關.SetActive(false);
        第三關特效.SetActive(false);
    }
}
