using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 第三關怪物生成 : MonoBehaviour
{
    public GameObject targetEnemy;
    //生成怪物的總數量
    public int enemyTotalNum = 2;
    //生成怪物的時間間隔
    public float intervalTime = 3;

    public int 第幾個生成器;

    void Start()
    {
        //玩家

        //初始時，怪物計數爲0；

        //重複生成怪物
        if (第幾個生成器 == 1)
        {
            InvokeRepeating("生成肌肉殭屍", 0.5F, intervalTime );
        }
        if (第幾個生成器 == 2)
        {
            InvokeRepeating("生成殭屍", 0.5F, intervalTime);
        }
    }
    void Update()
    {
        Debug.Log(第三關儲存空間.殭屍總數);
    }
    //方法，生成怪物
    private void 生成肌肉殭屍()
    {
        //如果玩家存活
        if (第三關儲存空間.P1HP > 0 || 第三關儲存空間.P2HP > 0)
        {
            //生成一隻怪物
            Instantiate(targetEnemy, this.transform.position, Quaternion.identity);
            第三關儲存空間.肌肉殭屍總數++;
            //如果計數達到最大值
            if (第三關儲存空間.肌肉殭屍總數 >= enemyTotalNum)
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

    private void 生成殭屍()
    {
        //如果玩家存活
        if (第三關儲存空間.P1HP > 0 || 第三關儲存空間.P2HP > 0)
        {
            //生成一隻怪物
            Instantiate(targetEnemy, this.transform.position, Quaternion.identity);
            第三關儲存空間.殭屍總數++;
            //如果計數達到最大值
            if (第三關儲存空間.殭屍總數 >= enemyTotalNum)
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
