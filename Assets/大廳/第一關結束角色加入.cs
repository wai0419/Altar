using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 第一關結束角色加入 : MonoBehaviour
{
    public GameObject 加入地點1;
    public GameObject 加入地點2;


    public GameObject 鍵盤右P1;
    public GameObject 鍵盤右P2;


    public GameObject 鍵盤左P1;
    public GameObject 鍵盤左P2;

    public GameObject 大廳加入;
    public GameObject 大廳對話;
    void Start()
    {
        Debug.Log("SaveData.鍵盤左" + SaveData.鍵盤左);
        Debug.Log("SaveData.鍵盤右" + SaveData.鍵盤右);

  
    }
    void Update()
    {
        if (SaveData.第一關完成 == true)
        {
            大廳加入.SetActive(false);
            大廳對話.SetActive(false);
            儲存空間.對話段 = 2;
            SaveData.第一關完成 = false;
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

        if (第二關儲存空間.第二關完成 == true)
        {
            大廳加入.SetActive(false);
            大廳對話.SetActive(false);
            儲存空間.對話段 = 3;
            第二關儲存空間.第二關完成 = false;
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

        if (第三關儲存空間.第三關完成 == true)
        {
            大廳加入.SetActive(false);
            大廳對話.SetActive(false);
            儲存空間.對話段 = 4;
            第三關儲存空間.第三關完成 = false;
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

}
