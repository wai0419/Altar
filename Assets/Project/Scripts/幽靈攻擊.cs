using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 幽靈攻擊 : MonoBehaviour
{
    private void OnTriggerEnter(Collider col)
    {

        if (col.tag == "Player")
        {
            var EMHP = col.GetComponent<P1>();
            if (EMHP != null)
            {
                EMHP.扣血特效();
            }
            SaveData.P1HP -=0.2f;
            Debug.Log(SaveData.P1HP);
        }
        if (col.tag == "P2")
        {
            var EMHP = col.GetComponent<P2>();
            if (EMHP != null)
            {
                EMHP.扣血特效();
            }
            SaveData.P2HP -=0.2f;
            Debug.Log(SaveData.P2HP);
        }

    }
}
