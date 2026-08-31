using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class 時間 : MonoBehaviour
{
    public int m_seconds;

    public int m_min;
    public int m_sec;

    public Text m_timer;
    

    public GameObject 成功畫面;

    public GameObject 失敗畫面;

    public GameObject 面板;

    public GameObject 跳轉放大;

    public GameObject Ready畫面;

    public GameObject Start畫面;

    public AudioSource 遊戲成功;

    public AudioSource 遊戲結束;

    public GameObject 零;

    public GameObject 一;

    public GameObject 二;

    public GameObject 三;
    // Start is called before the first frame update
    void Start()
    {

        StartCoroutine(Countdown());

        跳轉放大.SetActive(true);

        Invoke("Ready畫面顯示", 1.5f);

        Invoke("Start畫面顯示", 2.5f);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {

            m_min = 0;
            m_seconds = 3;
            m_sec = 3;
            SaveData.吸量 = 3;
            SaveData.幽量 = 3;
        }

        if (SaveData.P1HP ==2 && SaveData.P2HP ==2)
        {
            SaveData.遊戲結束 = true;
            m_min = 0;
            m_seconds = 0;
            m_sec = 0;
        }


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

        if (SaveData.吸量 <= 2 && SaveData.幽量 <= 2)
        {
            零.SetActive(true);
            if (!遊戲結束.isPlaying)
            {
                遊戲結束.Play();
            }
            SaveData.遊戲結束 = true;
            失敗畫面.SetActive(true);
            Invoke("復原", 3f);
            Destroy(GameObject.FindWithTag("Player"));
            Destroy(GameObject.FindWithTag("P2"));
        }
        if (SaveData.吸量 >= 3 && SaveData.幽量 >= 3&& SaveData.吸量 <= 5 && SaveData.幽量<=5)
        {
            SaveData.第一關完成 = true;
            一.SetActive(true);
            if (!遊戲成功.isPlaying)
            {
                遊戲成功.Play();
            }
            SaveData.遊戲結束 = true;
            成功畫面.SetActive(true);
            Invoke("復原", 3f);
            Destroy(GameObject.FindWithTag("Player"));
            Destroy(GameObject.FindWithTag("P2"));
        }

        if (SaveData.吸量 >= 6 && SaveData.幽量 >= 6 && SaveData.吸量 <= 8 && SaveData.幽量 <= 8)
        {
            SaveData.第一關完成 = true;
            二.SetActive(true);
            if (!遊戲成功.isPlaying)
            {
                遊戲成功.Play();
            }
            SaveData.遊戲結束 = true;
            成功畫面.SetActive(true);
            Invoke("復原", 3f);
            Destroy(GameObject.FindWithTag("Player"));
            Destroy(GameObject.FindWithTag("P2"));
        }

        if (SaveData.吸量 >= 9 && SaveData.幽量 >= 9 && SaveData.吸量 <= 11 && SaveData.幽量 <= 11)
        {
            SaveData.第一關完成 = true;
            三.SetActive(true);
            if (!遊戲成功.isPlaying)
            {
                遊戲成功.Play();
            }
            SaveData.遊戲結束 = true;
            成功畫面.SetActive(true);
            Invoke("復原", 3f);
            Destroy(GameObject.FindWithTag("Player"));
            Destroy(GameObject.FindWithTag("P2"));
        }
        //Time.timeScale = 0;
    }
    void 復原()
    {
        面板.SetActive(true);
        成功畫面.SetActive(false);
        失敗畫面.SetActive(false);

    }
    public void 結算返回主頁面()
    {
        歸零();
        SceneManager.LoadScene(0);
    }
    public void 返回大廳()
    {
        歸零();
        SceneManager.LoadScene(1);
    }
    public void 結算重來()
    {
        歸零();
        SceneManager.LoadScene(2);

    }
    void Ready畫面顯示()
    {
        Ready畫面.SetActive(true);
    }

    void Start畫面顯示()
    {

        Ready畫面.SetActive(false);
        Start畫面.SetActive(true);
        Invoke("顯示消失", 1f);
    }

    void 顯示消失()
    {
        Ready畫面.SetActive(false);
        Start畫面.SetActive(false);

    }
    public void 歸零()
    {
        零.SetActive(false);
        一.SetActive(false);
        二.SetActive(false);
        三.SetActive(false);
        //生成怪物的計數器
        SaveData.EnemyCounter = 0;

        SaveData.生幽 = 0;
        //玩家1血量
        SaveData.P1HP = 1;

        //玩家2血量
        SaveData.P2HP = 1;

        SaveData.P1拿起 = false;

        SaveData.P2拿起 = false;

        SaveData.P1開始調藥水 = false;

        SaveData.P2開始調藥水 = false;

        SaveData.P1開始調藥水次數 = 0;

        SaveData.P2開始調藥水次數 = 0;

        SaveData.鍋子1正在運作 = false;

        SaveData.鍋子2正在運作 = false;

        SaveData.鍋子1生成藥水 = false;

        SaveData.鍋子2生成藥水 = false;

        SaveData.祭壇一有怪物 = false;

        SaveData.祭壇二有怪物 = false;

        SaveData.祭壇三有怪物 = false;

        SaveData.P1攻擊中 = false;

        SaveData.P2攻擊中 = false;

        SaveData.暫停 = false;

        SaveData.P1開始裝水 = false;

        SaveData.P2開始裝水 = false;


        SaveData.P1開始裝滿水 = false;

        SaveData.P2開始裝滿水 = false;

        SaveData.吸量 = 0;

        SaveData.幽量 = 0;

        SaveData.音量 = 0.2f;

        //SaveData.亮度 = 0.2f;

        SaveData.遊戲結束 = false;
    }
}
