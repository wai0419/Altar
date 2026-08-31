using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 第三關敵人武器 : MonoBehaviour
{
    public GameObject 敵人;
    private void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player"&&敵人.GetComponent<第三關敵人>().攻擊中==true)
        {
            第三關儲存空間.P1HP -= 0.2f;
            col.GetComponent<第三關玩家血量>().扣血(); ;
        }
        if (col.tag == "P2" && 敵人.GetComponent<第三關敵人>().攻擊中 == true)
        {
            第三關儲存空間.P2HP -= 0.2f;
            col.GetComponent<第三關玩家血量>().扣血(); ;
        }
    }
}
