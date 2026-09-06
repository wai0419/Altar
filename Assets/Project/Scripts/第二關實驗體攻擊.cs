using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 第二關實驗體攻擊 : MonoBehaviour
{
    public GameObject 主體;

    private void OnTriggerEnter(Collider col)
    {

        if (col.tag == "Player"&&主體.GetComponent<第二關敵人>().死亡==false)
        {
            var EMHP = col.GetComponent<P1>();
            if (EMHP != null)
            {
                //EMHP.扣血特效();
            }

            第二關儲存空間.P1HP -= 0.2f;
            Debug.Log(第二關儲存空間.P1HP);
        }
        if (col.tag == "P2" && 主體.GetComponent<第二關敵人>().死亡 == false)
        {
            var EMHP = col.GetComponent<P2>();
            if (EMHP != null)
            {
                //EMHP.扣血特效();
            }

            第二關儲存空間.P2HP -= 0.2f;
            Debug.Log(第二關儲存空間.P2HP);
        }

    }

}
