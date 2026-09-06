using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ESC : MonoBehaviour
{
    public GameObject 暫停畫面;

    public bool 暫停=false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Time.timeScale);
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            暫停 = !暫停;
            if(暫停)
            {
                暫停畫面.SetActive(true);

                Time.timeScale = 0;
            }
            else
            {
                暫停畫面.SetActive(false);
                Time.timeScale = 1;
            }

        }
    }

    public void 返回()
    {
        Time.timeScale = 1;
        SaveData.暫停 = false;
        
    }
    public void 重新開始()
    {
        Time.timeScale = 1;
        SaveData.暫停 = false;
        SceneManager.LoadScene(2);
        歸零();
    }

    public void 返回主頁面()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
        歸零();
    }
    public void 歸零()
    {
        
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
