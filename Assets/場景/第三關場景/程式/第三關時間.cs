using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class 第三關時間 : MonoBehaviour
{
public int m_seconds;

    public int m_min;
    public int m_sec;

    public Text m_timer;

    public GameObject 跳轉放大;

    public GameObject 跳轉縮小;

    public GameObject Ready畫面;

    public GameObject Start畫面;

    public GameObject 暫停畫面;

    public GameObject 成功畫面;

    public GameObject 失敗畫面;

    public GameObject 結算畫面;

    public bool 暫停 = false;

    public Text 肌肉殭屍數量;

    public Text 一般殭屍數量;

    public GameObject 零;

    public GameObject 一;

    public GameObject 二;

    public GameObject 三;

    public GameObject 提示;

    public AudioSource 遊戲成功;

    public AudioSource 遊戲結束;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Countdown());
        跳轉放大.SetActive(true);
        Destroy(跳轉放大, 5f);
        Invoke("Ready畫面顯示", 1.5f);

        Invoke("Start畫面顯示", 2.5f);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {

            m_min = 0;
            m_seconds = 3;
            m_sec = 3;
            第三關儲存空間.肌肉殭屍分數 = 3;
            第三關儲存空間.殭屍分數 = 3;

        }

        if (第三關儲存空間.P1HP == 2 && 第三關儲存空間.P2HP == 2)
        {
            第三關儲存空間.遊戲結束 = true;
            m_min = 0;
            m_seconds = 0;
            m_sec = 0;
        }
        肌肉殭屍數量.text = 第三關儲存空間.肌肉殭屍分數.ToString() + "/3";
        一般殭屍數量.text = 第三關儲存空間.殭屍分數.ToString() + "/3";

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            暫停 = !暫停;
            if (暫停)
            {
                暫停畫面.SetActive(true);
                
                Time.timeScale = 0;
            }
            else
            {
                暫停畫面.SetActive(false);
                提示.SetActive(false);
                Time.timeScale = 1;
            }

        }


    }
    void 復原()
    {
        結算畫面.SetActive(true);
        成功畫面.SetActive(false);
        失敗畫面.SetActive(false);

    }
    public void 結算返回主頁面()
    {
        歸零();
        SceneManager.LoadScene(0);
    }
    public void 結算重來()
    {
        歸零();
        SceneManager.LoadScene(4);

    }
    public void 歸零()
    {
        第三關儲存空間.P1HP = 1;

        第三關儲存空間.P2HP = 1;

        第三關儲存空間.肌肉殭屍總數 = 2;

        第三關儲存空間.殭屍總數 = 2;

        第三關儲存空間.肌肉殭屍分數 = 0;

        第三關儲存空間.殭屍分數 = 0;

        
}
    IEnumerator Countdown()
    {
        m_timer.text = string.Format("{0}:{1}", m_min.ToString("00"), m_sec.ToString("00"));
        m_seconds = (m_min * 60) + m_sec;

        while (m_seconds > 0)
        {
            yield return new WaitForSeconds(1);

            m_seconds--;
            m_sec--;

            if (m_sec < 0 && m_min > 0)
            {
                m_min -= 1;
                m_sec = 59;
            }

            else if (m_sec < 0 && m_min == 0)
            {
                m_sec = 0;
            }
            m_timer.text = string.Format("{0}:{1}", m_min.ToString("00"), m_sec.ToString("00"));
        }
        yield return new WaitForSeconds(1);
        if (第三關儲存空間.肌肉殭屍分數 < 3 && 第三關儲存空間.殭屍分數 < 3)
        {
            第三關儲存空間.第三關完成 = false;
            if (!遊戲結束.isPlaying)
            {
                遊戲結束.Play();
            }
            零.SetActive(true);
            第三關儲存空間.遊戲結束 = true;
            失敗畫面.SetActive(true);
            Invoke("復原", 3f);
            Destroy(GameObject.FindWithTag("Player"));
            Destroy(GameObject.FindWithTag("P2"));
        }
        if (第三關儲存空間.肌肉殭屍分數 >= 3 && 第三關儲存空間.殭屍分數 >= 3 && 第三關儲存空間.肌肉殭屍分數 <= 5 && 第三關儲存空間.殭屍分數 <= 5)
        {
            第三關儲存空間.第三關完成 = true;
            if (!遊戲成功.isPlaying)
            {
                遊戲成功.Play();
            }
            一.SetActive(true);
            第三關儲存空間.遊戲結束 = true;
            成功畫面.SetActive(true);
            Invoke("復原", 3f);
            Destroy(GameObject.FindWithTag("Player"));
            Destroy(GameObject.FindWithTag("P2"));
        }
        if (第三關儲存空間.肌肉殭屍分數 >= 6 && 第三關儲存空間.殭屍分數 >= 6 && 第三關儲存空間.肌肉殭屍分數 <= 7 && 第三關儲存空間.殭屍分數 <= 7)
        {
            第三關儲存空間.第三關完成 = true;
            if (!遊戲成功.isPlaying)
            {
                遊戲成功.Play();
            }
            二.SetActive(true);
            第三關儲存空間.遊戲結束 = true;
            成功畫面.SetActive(true);
            Invoke("復原", 3f);
            Destroy(GameObject.FindWithTag("Player"));
            Destroy(GameObject.FindWithTag("P2"));
        }
        if (第三關儲存空間.肌肉殭屍分數 >= 8 && 第三關儲存空間.殭屍分數 >= 8 && 第三關儲存空間.肌肉殭屍分數 <= 10 && 第三關儲存空間.殭屍分數 <= 10)
        {
            第三關儲存空間.第三關完成 = true;
            if (!遊戲成功.isPlaying)
            {
                遊戲成功.Play();
            }
            三.SetActive(true);
            第三關儲存空間.遊戲結束 = true;
            成功畫面.SetActive(true);
            Invoke("復原", 3f);
            Destroy(GameObject.FindWithTag("Player"));
            Destroy(GameObject.FindWithTag("P2"));
        }
    }

    void Ready畫面顯示()
    {
        Ready畫面.SetActive(true);
    }

    void Start畫面顯示()
    {
        //mySl.PlayOneShot(Start聲音);
        Ready畫面.SetActive(false);
        Start畫面.SetActive(true);
        Invoke("顯示消失", 1f);
    }

    void 顯示消失()
    {
        Ready畫面.SetActive(false);
        Start畫面.SetActive(false);

    }
    public void 返回()
    {
        暫停 =false;
        SaveData.暫停 = false;
        Time.timeScale = 1;

    }
    public void 重新開始()
    {
        歸零();
        SaveData.暫停 = false;
        Time.timeScale = 1;
        SceneManager.LoadScene(4);

    }

    public void 返回主頁面()
    {
        歸零();
        SceneManager.LoadScene(1);
    }
    public void 返回封面()
    {
        歸零();
        SceneManager.LoadScene(0);
    }
}
