using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 武器 : MonoBehaviour
{
    public int D = 0;

    private void OnTriggerEnter(Collider col)
    {
        
        if (col.tag == "Player"&&D==1)
        {
            var EMHP = col.GetComponent<P1>();
            if (EMHP != null)
            {
                EMHP.扣血特效();
            }
            Invoke("D0", 0.000000001f);
            SaveData.P1HP = SaveData.P1HP - 0.2f;
            Debug.Log(SaveData.P1HP);
        }
        if (col.tag == "P2" && D == 1)
        {
            var EMHP = col.GetComponent<P2>();
            if (EMHP != null)
            {
                EMHP.扣血特效();
            }
            Invoke("D0", 0.000000001f);
            SaveData.P2HP -= 0.2f;
            Debug.Log(SaveData.P2HP);
        }

    }
    private void OnTriggerExit(Collider other)
    {
        Invoke("D1", 2f);
    }
    void D1()
    {
        D = 1;
    }
    void D0()
    {
        D = 0;
    }
}
