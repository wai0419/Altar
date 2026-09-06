using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 角色資料加入 : MonoBehaviour
{
    public GameObject 加入地點1;
    public GameObject 加入地點2;
    public GameObject 加入地點3;
    public GameObject 加入地點4;

    public GameObject 鍵盤右P1;
    public GameObject 鍵盤右P2;
    public GameObject 鍵盤右P3;
    public GameObject 鍵盤右P4;

    public GameObject 鍵盤左P1;
    public GameObject 鍵盤左P2;
    public GameObject 鍵盤左P3;
    public GameObject 鍵盤左P4;

    public GameObject 手把P1;
    public GameObject 手把P2;
    public GameObject 手把P3;
    public GameObject 手把P4;

    public GameObject 第二手把P1;
    public GameObject 第二手把P2;
    public GameObject 第二手把P3;
    public GameObject 第二手把P4;

    void Start()
    {
        Debug.Log("SaveData.鍵盤左" + SaveData.鍵盤左);
        Debug.Log("SaveData.鍵盤右" + SaveData.鍵盤右);
        Debug.Log("SaveData.手把1" + SaveData.手把1);
        if (SaveData.手把1 > 0)
        {
            switch (SaveData.手把1)
            {
                case 1:
                    
                    Instantiate(手把P1, 加入地點1.transform.position, Quaternion.identity);
                    break;
                case 2:
                    
                    Instantiate(手把P2, 加入地點2.transform.position, Quaternion.identity);
                    break;
            }
        }
        if (SaveData.鍵盤右 > 0)
        {
            switch (SaveData.鍵盤右)
            {
                case 1:
                    
                    Instantiate(鍵盤右P1, 加入地點1.transform.position, Quaternion.identity);
                    break;
                case 2:
                    
                    Instantiate(鍵盤右P2, 加入地點2.transform.position, Quaternion.identity);
                    break;
            }
        }
        if (SaveData.鍵盤左 > 0)
        {
            switch (SaveData.鍵盤左)
            {
                case 1:

                    Instantiate(鍵盤左P1, 加入地點1.transform.position, Quaternion.identity);
                    break;
                case 2:

                    Instantiate(鍵盤左P2, 加入地點2.transform.position, Quaternion.identity);
                    break;
            }
        }
    }

}
