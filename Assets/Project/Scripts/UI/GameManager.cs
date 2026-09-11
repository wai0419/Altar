using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject GameStopMenu;
    public GameObject Hints;

    public bool isGameStop = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            isGameStop = !isGameStop;
            if (isGameStop)
            {
                GameStopMenu.SetActive(true);
                Time.timeScale = 0;
            }
            else
            {
                GameStopMenu.SetActive(false);
                Time.timeScale = 1;
            }
        }
    }

    public void GameContinue()
    {
        Time.timeScale = 1;
        SaveData.暫停 = false;

    }
    public void GameRestart()
    {
        Time.timeScale = 1;
        SaveData.暫停 = false;
        SceneManager.LoadScene(2);
        歸零();
    }

    public void GameBack()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
        歸零();
    }

    public void GameOptions()
    {
        Hints.SetActive(true);
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

        SaveData.遊戲結束 = false;
    }
}
