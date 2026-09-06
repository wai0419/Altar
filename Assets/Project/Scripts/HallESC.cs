using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HallESC : MonoBehaviour
{
    public int 拾取計數器 = 1;

    public GameObject 暫停畫面;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Escape) && 拾取計數器 == 1)
        {
            Invoke("D0", 0.1f);
            SaveData.暫停 = true;

            暫停畫面.SetActive(true);
            //P2.SetActive(false);

        }
        if (Input.GetKeyDown(KeyCode.Escape) && 拾取計數器 == 0)
        {
            Invoke("D1", 0.1f);
            SaveData.暫停 = false;
            暫停畫面.SetActive(false);
            //P1.SetActive(true);
            //P2.SetActive(true);

        }
    }
    void D1()
    {
        拾取計數器 = 1;
    }
    void D0()
    {
        拾取計數器 = 0;
    }

    public void 返回()
    {
        Invoke("D1", 0.1f);

        SaveData.暫停 = false;


    }
    public void 重新開始()
    {
        SaveData.暫停 = false;
        Invoke("D1", 0.1f);
        SceneManager.LoadScene(1);
        歸零();
    }

    public void 返回主頁面()
    {
        Invoke("D1", 0.1f);
        SceneManager.LoadScene(0);
        歸零();
    }
    public void 歸零()
    {

        //生成怪物的計數器
        SaveData.EnemyCounter = 0;

        SaveData.生幽 = 0;
        //玩家1血量
        SaveData.P1HP = 5;

        //玩家2血量
        SaveData.P2HP = 5;

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
