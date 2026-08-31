using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 第二關玩家武器 : MonoBehaviour
{

    private void OnTriggerEnter(Collider col)
    {

        if (col.tag == "實驗體X33"&& SaveData.P2攻擊中==true)
        {
            Debug.Log("--------");
            var EMHP = col.GetComponent<第二關敵人>();
            if (EMHP != null)
                EMHP.扣血();
        }
        if (col.tag == "實驗體X33" && SaveData.P1攻擊中 == true)
        {
            Debug.Log("--------");
            var EMHP = col.GetComponent<第二關敵人>();
            if (EMHP != null)
                EMHP.扣血();
        }
        if (col.tag == "實驗熊" && SaveData.P2攻擊中 == true)
        {
            Debug.Log("--------");
            var EMHP = col.GetComponent<第二關敵人>();
            if (EMHP != null)
                EMHP.扣血();
        }
        if (col.tag == "實驗熊" && SaveData.P1攻擊中 == true)
        {
            Debug.Log("--------");
            var EMHP = col.GetComponent<第二關敵人>();
            if (EMHP != null)
                EMHP.扣血();
        }
        if (col.tag == "輪椅模式" && SaveData.P2攻擊中 == true)
        {
            Debug.Log("--------");
            var EMHP = col.GetComponent<輪椅怪>();
            if (EMHP != null)
                EMHP.扣血();
        }
        if (col.tag == "輪椅模式" && SaveData.P1攻擊中 == true)
        {
            Debug.Log("--------");
            var EMHP = col.GetComponent<輪椅怪>();
            if (EMHP != null)
                EMHP.扣血();
        }
        if (col.tag == "實驗輪椅" && SaveData.P2攻擊中 == true)
        {
            Debug.Log("--------");
            var EMHP = col.GetComponent<第二關敵人>();
            if (EMHP != null)
                EMHP.扣血();
        }
        if (col.tag == "實驗輪椅" && SaveData.P1攻擊中 == true)
        {
            Debug.Log("--------");
            var EMHP = col.GetComponent<第二關敵人>();
            if (EMHP != null)
                EMHP.扣血();
        }
    }
}
