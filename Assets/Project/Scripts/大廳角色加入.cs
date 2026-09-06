using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class 大廳角色加入 : MonoBehaviour
{
    public GameObject UI空加入1;
    public GameObject UI空加入2;
    public GameObject UI空加入3;
    public GameObject UI空加入4;

    public GameObject UI有加入1;
    public GameObject UI有加入2;
    public GameObject UI有加入3;
    public GameObject UI有加入4;

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

    public int NO = 1;

    public bool 控制1 = false;
    public bool 控制2 = false;
    public bool 控制3 = false;
    public bool 控制4 = false;
    public bool 控制5 = false;
    public bool 控制6 = false;

    void Start()
    {

    }
    void Update()
    {
        int l = Gamepad.all.Count;

        //Right右玩家
        if (Input.GetKeyDown(KeyCode.RightControl) && 控制1 == false)
        {
            switch (NO)
            {
                case 1:
                    Instantiate(鍵盤右P1, 加入地點1.transform.position, Quaternion.identity);
                    NO++;
                    控制1 = true;
                    SaveData.鍵盤右 = 1;
                    UI空加入1.SetActive(false);
                    UI有加入1.SetActive(true);
                    break;
                case 2:
                    Instantiate(鍵盤右P2, 加入地點2.transform.position, Quaternion.identity);
                    NO++;
                    控制1 = true;
                    SaveData.鍵盤右 = 2;
                    UI空加入2.SetActive(false);
                    UI有加入2.SetActive(true);
                    break;
                case 3:
                    Instantiate(鍵盤右P3, 加入地點3.transform.position, Quaternion.identity);
                    NO++;
                    控制1 = true;
                    SaveData.鍵盤右 = 3;
                    UI空加入3.SetActive(false);
                    UI有加入3.SetActive(true);
                    break;
                case 4:
                    Instantiate(鍵盤右P4, 加入地點4.transform.position, Quaternion.identity);
                    NO++;
                    控制1 = true;
                    SaveData.鍵盤右 = 4;
                    UI空加入4.SetActive(false);
                    UI有加入4.SetActive(true);
                    break;
            }
        }

        //Left左玩家
        if (Input.GetKeyDown(KeyCode.LeftControl) && 控制2 == false)
        {
            switch (NO)
            {
                case 1:
                    Instantiate(鍵盤左P1, 加入地點1.transform.position, Quaternion.identity);
                    NO++;
                    控制2 = true;
                    SaveData.鍵盤左 = 1;
                    UI空加入1.SetActive(false);
                    UI有加入1.SetActive(true);
                    break;
                case 2:
                    Instantiate(鍵盤左P2, 加入地點2.transform.position, Quaternion.identity);
                    NO++;
                    控制2 = true;
                    SaveData.鍵盤左 = 2;
                    UI空加入2.SetActive(false);
                    UI有加入2.SetActive(true);
                    break;
                case 3:
                    Instantiate(鍵盤左P3, 加入地點3.transform.position, Quaternion.identity);
                    NO++;
                    控制2 = true;
                    SaveData.鍵盤左 = 3;
                    UI空加入3.SetActive(false);
                    UI有加入3.SetActive(true);
                    break;
                case 4:
                    Instantiate(鍵盤左P4, 加入地點4.transform.position, Quaternion.identity);
                    NO++;
                    控制2 = true;
                    SaveData.鍵盤左 = 4;
                    UI空加入4.SetActive(false);
                    UI有加入4.SetActive(true);
                    break;
            }
        }

        //手把1玩家
        if(l>0)
        {
            if (Gamepad.all[0].buttonSouth.wasPressedThisFrame && 控制3 == false)
            {
                switch (NO)
                {
                    case 1:
                        Instantiate(手把P1, 加入地點4.transform.position, Quaternion.identity);
                        NO++;
                        控制3 = true;
                        SaveData.手把1 = 1;
                        UI空加入1.SetActive(false);
                        UI有加入1.SetActive(true);
                        break;
                    case 2:
                        Instantiate(手把P2, 加入地點4.transform.position, Quaternion.identity);
                        NO++;
                        控制3 = true;
                        SaveData.手把1 = 2;
                        UI空加入2.SetActive(false);
                        UI有加入2.SetActive(true);
                        break;
                    case 3:
                        Instantiate(手把P3, 加入地點4.transform.position, Quaternion.identity);
                        NO++;
                        控制3 = true;
                        SaveData.手把1 = 3;
                        UI空加入3.SetActive(false);
                        UI有加入3.SetActive(true);
                        break;
                    case 4:
                        Instantiate(手把P4, 加入地點4.transform.position, Quaternion.identity);
                        NO++;
                        控制3 = true;
                        SaveData.手把1 = 4;
                        UI空加入4.SetActive(false);
                        UI有加入4.SetActive(true);
                        break;
                }
            }
        }
        

        
        if(l>1)
        {
            if (Gamepad.all[1].buttonSouth.wasPressedThisFrame && 控制4 == false)
            {
                switch (NO)
                {
                    case 1:
                        Instantiate(手把P1, 加入地點4.transform.position, Quaternion.identity);
                        NO++;
                        控制4 = true;
                        SaveData.手把2 = 1;
                        UI空加入1.SetActive(false);
                        UI有加入1.SetActive(true);
                        break;
                    case 2:
                        Instantiate(手把P2, 加入地點4.transform.position, Quaternion.identity);
                        NO++;
                        控制4 = true;
                        SaveData.手把2 = 2;
                        UI空加入2.SetActive(false);
                        UI有加入2.SetActive(true);
                        break;
                    case 3:
                        Instantiate(手把P3, 加入地點4.transform.position, Quaternion.identity);
                        NO++;
                        控制4 = true;
                        SaveData.手把2 = 3;
                        UI空加入3.SetActive(false);
                        UI有加入3.SetActive(true);
                        break;
                    case 4:
                        Instantiate(手把P4, 加入地點4.transform.position, Quaternion.identity);
                        NO++;
                        控制4 = true;
                        SaveData.手把2 = 4;
                        UI空加入4.SetActive(false);
                        UI有加入4.SetActive(true);
                        break;
                }
            }

            if (Gamepad.all[1].buttonEast.wasPressedThisFrame && SaveData.手把2 > 0)
            {
                switch (SaveData.手把2)
                {
                    case 1:
                        NO--;
                        控制4 = false;
                        SaveData.手把2 = 0;
                        UI空加入1.SetActive(true);
                        UI有加入1.SetActive(false);
                        Destroy(GameObject.FindWithTag("P3"));
                        break;
                    case 2:
                        NO--;
                        控制4 = false;
                        SaveData.手把2 = 0;
                        UI空加入1.SetActive(true);
                        UI有加入1.SetActive(false);
                        Destroy(GameObject.FindWithTag("P3"));
                        break;
                    case 3:
                        NO--;
                        控制4 = false;
                        SaveData.手把2 = 0;
                        UI空加入3.SetActive(true);
                        UI有加入3.SetActive(false);
                        Destroy(GameObject.FindWithTag("P3"));
                        break;
                }
            }
        }

        
    }
}
