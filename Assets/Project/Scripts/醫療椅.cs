using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class 醫療椅 : MonoBehaviour
{
    public bool 是否有怪物在上面;

    public bool 是否有實驗體在上面;

    public bool 是否有實驗熊在上面;

    public bool 是否有實驗輪椅在上面;

    

    public bool 支解完成;

    public bool 繃帶處理完成;


    [Header("實驗體1")]
    public GameObject 實驗體1;

    public GameObject 支解實驗體1;

    public GameObject 繃帶支解實驗體1;

    [Header("實驗熊")]
    public GameObject 實驗熊;

    public GameObject 處理過實驗熊;

    public GameObject 繃帶實驗熊;

    [Header("實驗輪椅")]
    public GameObject 實驗輪椅;

    public GameObject 處理過實驗輪椅;

    public GameObject 繃帶實驗輪椅;

    public GameObject 進度UI;

    public Image 進度;

    public AudioSource 繃帶成功聲;

    public AudioSource 完成聲;
    public void 顯示實驗體1()
    {
        實驗體1.SetActive(true);
    }

    public void 支解怪物()
    {
        支解完成 = true;
        實驗體1.SetActive(false);
        支解實驗體1.SetActive(true);
    }
    public void 繃帶支解怪物()
    {
        繃帶處理完成 = true;
        支解實驗體1.SetActive(false);
        繃帶支解實驗體1.SetActive(true);
    }
    public void 消失()
    {
        if (!完成聲.isPlaying)
        {
            完成聲.Play();
        }
        支解完成 = false;
        繃帶處理完成 = false;
        實驗體1.SetActive(false);
        支解實驗體1.SetActive(false);
        繃帶支解實驗體1.SetActive(false);
    }



    //實驗熊
    public void 顯示實驗熊()
    {
        實驗熊.SetActive(true);
    }

    public void 支解實驗熊()
    {
        支解完成 = true;
        實驗熊.SetActive(false);
        處理過實驗熊.SetActive(true);
    }
    public void 繃帶支解實驗熊()
    {
        繃帶處理完成 = true;
        處理過實驗熊.SetActive(false);
        繃帶實驗熊.SetActive(true);
    }
    public void 消失實驗熊()
    {
        if (!完成聲.isPlaying)
        {
            完成聲.Play();
        }
        支解完成 = false;
        繃帶處理完成 = false;
        實驗熊.SetActive(false);
        處理過實驗熊.SetActive(false);
        繃帶實驗熊.SetActive(false);
    }

    //實驗輪椅
    public void 顯示實驗輪椅()
    {
        實驗輪椅.SetActive(true);
    }

    public void 支解實驗輪椅()
    {
        支解完成 = true;
        實驗輪椅.SetActive(false);
        處理過實驗輪椅.SetActive(true);
    }
    public void 繃帶支解實驗輪椅()
    {
        繃帶處理完成 = true;
        處理過實驗輪椅.SetActive(false);
        繃帶實驗輪椅.SetActive(true);
    }
    public void 消失實驗輪椅()
    {
        if (!完成聲.isPlaying)
        {
            完成聲.Play();
        }
        支解完成 = false;
        繃帶處理完成 = false;
        實驗輪椅.SetActive(false);
        處理過實驗輪椅.SetActive(false);
        繃帶實驗輪椅.SetActive(false);
    }

    public void 進度條()
    {
        進度UI.SetActive(true);
        if (進度.GetComponent<Image>().fillAmount >= 0)
        {
            InvokeRepeating("增加進度條", 2f, 2f);
        }
    }
    public void 增加進度條()
    {
        進度.GetComponent<Image>().fillAmount -= 0.1f;
        if (進度.GetComponent<Image>().fillAmount <= 0 && 是否有實驗體在上面 == true)
        {
            if (!繃帶成功聲.isPlaying)
            {
                繃帶成功聲.Play();
            }
            繃帶支解怪物();
            CancelInvoke();
            進度UI.SetActive(false);

            進度.GetComponent<Image>().fillAmount = 1;
        }
        if (進度.GetComponent<Image>().fillAmount <= 0 && 是否有實驗熊在上面 == true)
        {
            if (!繃帶成功聲.isPlaying)
            {
                繃帶成功聲.Play();
            }
            繃帶支解實驗熊();
            CancelInvoke();
            進度UI.SetActive(false);

            進度.GetComponent<Image>().fillAmount = 1;
        }
        if (進度.GetComponent<Image>().fillAmount <= 0 && 是否有實驗輪椅在上面 == true)
        {
            if (!繃帶成功聲.isPlaying)
            {
                繃帶成功聲.Play();
            }
            繃帶支解實驗輪椅();
            CancelInvoke();
            進度UI.SetActive(false);

            進度.GetComponent<Image>().fillAmount = 1;
        }
    }
    public void 暫停進度條()
    {
        CancelInvoke();
    }
}
