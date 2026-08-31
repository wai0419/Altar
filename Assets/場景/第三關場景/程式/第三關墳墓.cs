using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class 第三關墳墓 : MonoBehaviour
{
    public bool 是否有怪物在上面;

    public bool 是否有肌肉殭屍在上面;

    public bool 是否有一般殭屍在上面;

    public GameObject 土;

    public GameObject 處理過土;
    [Header("肌肉殭屍")]
    public GameObject 肌肉殭屍;

    [Header("一般殭屍")]
    public GameObject 一般殭屍;

    public bool 是否可以禱告;

    public GameObject 進度UI;

    public Image 進度;

    public AudioSource 完成聲;

    public AudioSource 禱告完聲;

    public ParticleSystem 法鎮特效;
    void Start()
    {
        法鎮特效.Stop();
        進度.GetComponent<Image>().fillAmount = 1f;
    }
    public void 顯示肌肉殭屍()
    {
        if (!完成聲.isPlaying)
        {
            完成聲.Play();
        }
        肌肉殭屍.SetActive(true);
    }
    public void 顯示一般殭屍()
    {
        if (!完成聲.isPlaying)
        {
            完成聲.Play();
        }
        一般殭屍.SetActive(true);
    }

    public void 埋肌肉殭屍()
    {
        if (!完成聲.isPlaying)
        {
            完成聲.Play();
        }
        肌肉殭屍.SetActive(true);
        處理過土.SetActive(true);
    }
    public void 埋一般殭屍()
    {
        if (!完成聲.isPlaying)
        {
            完成聲.Play();
        }
        一般殭屍.SetActive(false);
        處理過土.SetActive(true);
    }
    public void 一般殭屍分數()
    {
        法鎮特效.Stop();
        if (!禱告完聲.isPlaying)
        {
            禱告完聲.Play();
        }
        第三關儲存空間.殭屍總數 -= 1;
        處理過土.SetActive(false);
        土.SetActive(true);
        第三關儲存空間.殭屍分數 += 1;
    }
    public void 肌肉殭屍分數()
    {
        法鎮特效.Stop();
        if (!禱告完聲.isPlaying)
        {
            禱告完聲.Play();
        }
        第三關儲存空間.肌肉殭屍總數 -= 1;
        處理過土.SetActive(false);
        土.SetActive(true);
        第三關儲存空間.肌肉殭屍分數 += 1;
    }
    public void 進度條()
    {
        法鎮特效.Play();
        進度UI.SetActive(true);
        if (進度.GetComponent<Image>().fillAmount>=0&& 是否可以禱告==true)
        {
            InvokeRepeating("增加進度條", 2f, 2f);
        }
    }
    public void 增加進度條()
    {
        進度.GetComponent<Image>().fillAmount -= 0.1f;
        if(進度.GetComponent<Image>().fillAmount <= 0&& 是否有一般殭屍在上面==true)
        {
            if (!完成聲.isPlaying)
            {
                完成聲.Play();
            }
            CancelInvoke();
            進度UI.SetActive(false);
            一般殭屍分數();
            是否有一般殭屍在上面 = false;
            是否有怪物在上面 = false;
            是否可以禱告 = false;
            進度.GetComponent<Image>().fillAmount = 1;
        }
        if (進度.GetComponent<Image>().fillAmount <= 0 && 是否有肌肉殭屍在上面 == true)
        {
            if (!完成聲.isPlaying)
            {
                完成聲.Play();
            }
            CancelInvoke();
            進度UI.SetActive(false);
            是否有肌肉殭屍在上面 = false;
            是否有怪物在上面 = false;
            是否可以禱告 = false;
            肌肉殭屍分數();
            進度.GetComponent<Image>().fillAmount = 1;
        }
    }
    public void 暫停進度條()
    {
        CancelInvoke();
    }
}
