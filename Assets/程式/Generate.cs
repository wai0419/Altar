using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generate : MonoBehaviour
{
    //
    //生成怪物程式
    //

    public GameObject targetEnemy;
    //生成怪物的總數量
    public int enemyTotalNum = 5;
    //生成怪物的時間間隔
    public float intervalTime = 3;
    
    
    //玩家
    private GameObject targetPlayer;
    


    void Start()
    {
        //玩家

        //初始時，怪物計數爲0；

        //重複生成怪物
        InvokeRepeating("CreatEnemy", 0.5F, intervalTime);
    }


    void Update()
    {
        
    }
    //方法，生成怪物
    private void CreatEnemy()
    {
        //如果玩家存活
        if (SaveData.P1HP > 0|| SaveData.P2HP > 0)
        {
            //生成一隻怪物
            Instantiate(targetEnemy, this.transform.position, Quaternion.identity);
            SaveData.EnemyCounter++;
            //如果計數達到最大值
            if (SaveData.EnemyCounter >= enemyTotalNum)
            {
                //停止刷新
                CancelInvoke();
            }
        }
        //玩家死亡
        else
        {
            //停止刷新
            CancelInvoke();
        }   
    }
}
