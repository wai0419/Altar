using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 福馬林 : MonoBehaviour
{
    public GameObject 繃帶X33;

    public GameObject 實驗熊;

    public GameObject 實驗輪椅;

    public AudioSource 完成聲;
    public void 丟實驗體()
    {
        if (!完成聲.isPlaying)
        {
            完成聲.Play();
        }
        第二關儲存空間.實驗體總數 -= 1;
        第二關儲存空間.實驗體X33分數 += 1;
        繃帶X33.SetActive(true);
        Invoke("隱藏實驗體", 3f);
    }
    public void 隱藏()
    {
        繃帶X33.SetActive(false);
    }

    public void 丟實驗熊()
    {
        if (!完成聲.isPlaying)
        {
            完成聲.Play();
        }
        第二關儲存空間.實驗體熊總數 -= 1;
        第二關儲存空間.熊分數 += 1;
        實驗熊.SetActive(true);
        Invoke("隱藏", 3f);
    }
    public void 隱藏實驗熊()
    {
        實驗熊.SetActive(false);
    }

    public void 丟實驗輪椅()
    {
        if (!完成聲.isPlaying)
        {
            完成聲.Play();
        }
        第二關儲存空間.實驗體輪椅怪總數 -= 1;
        第二關儲存空間.腦袋分數 += 1;
        實驗輪椅.SetActive(true);
        Invoke("隱藏", 3f);
    }
    public void 隱藏實驗輪椅()
    {
        實驗輪椅.SetActive(false);
    }
}
