using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 鍋子1 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject 進度條;

    public GameObject 進度條1;

    public GameObject 進度條2;

    public GameObject 進度條3;

    public GameObject 進度條4;

    public GameObject 進度條5;

    public GameObject 進度條6;

    public GameObject 進度條7;

    public GameObject 進度條8;

    public GameObject 進度條9;

    public GameObject 進度條10;

    public GameObject 進度條11;

    public GameObject 進度條12;

    public GameObject 進度條13;

    public GameObject 進度條14;

    public GameObject 進度條15;

    public GameObject 進度條16;

    public GameObject 進度條17;

    public GameObject 進度條18;

    public bool 進度條Bool1;

    public bool 進度條Bool2;

    public bool 進度條Bool3;

    public bool 進度條Bool4;

    public bool 進度條Bool5;

    public bool 進度條Bool6;

    public bool 進度條Bool7;

    public bool 進度條Bool8;

    public bool 進度條Bool9;

    public bool 進度條Bool10;

    public bool 進度條Bool11;

    public bool 進度條Bool12;

    public bool 進度條Bool13;

    public bool 進度條Bool14;

    public bool 進度條Bool15;

    public bool 進度條Bool16;

    public bool 進度條Bool17;

    public bool 進度條Bool18;

    public int T = 0;

    public int D = 0;



    public void 開始調藥水()
    {

        if (D > 0)
        {
            T = D;
            switch (T)
            {
                case 0:
                    進度條.SetActive(true);

                    進度條1.SetActive(true);

                    Invoke("調藥水1", 0.5f);
                    break;
                case 1:
                    Invoke("調藥水2", 0.5f);
                    break;
                case 2:
                    Invoke("調藥水3", 0.5f);
                    break;
                case 3:
                    Invoke("調藥水4", 0.5f);
                    break;
                case 4:
                    Invoke("調藥水5", 0.5f);
                    break;
                case 5:
                    Invoke("調藥水6", 0.5f);
                    break;
                case 6:
                    Invoke("調藥水7", 0.5f);
                    break;
                case 7:
                    Invoke("調藥水8", 0.5f);
                    break;
                case 8:
                    Invoke("調藥水9", 0.5f);
                    break;
                case 9:
                    Invoke("調藥水10", 0.5f);
                    break;
                case 10:
                    Invoke("調藥水11", 0.5f);
                    break;
                case 11:
                    Invoke("調藥水12", 0.5f);
                    break;
                case 12:
                    Invoke("調藥水13", 0.5f);
                    break;
                case 13:
                    Invoke("調藥水14", 0.5f);
                    break;
                case 14:
                    Invoke("調藥水15", 0.5f);
                    break;
                case 15:
                    Invoke("調藥水16", 0.5f);
                    break;
                case 16:
                    Invoke("調藥水17", 0.5f);
                    break;
                case 17:
                    Invoke("調藥水18", 0.5f);
                    break;
                case 18:
                    Invoke("結束", 0.5f);
                    break;
            }
        }
        else
            switch (T)
            {
                case 0:
                    進度條.SetActive(true);

                    進度條1.SetActive(true);

                    Invoke("調藥水1", 0.5f);
                    break;
                case 1:
                    Invoke("調藥水2", 0.5f);
                    break;
                case 2:
                    Invoke("調藥水3", 0.5f);
                    break;
                case 3:
                    Invoke("調藥水4", 0.5f);
                    break;
                case 4:
                    Invoke("調藥水5", 0.5f);
                    break;
                case 5:
                    Invoke("調藥水6", 0.5f);
                    break;
                case 6:
                    Invoke("調藥水7", 0.5f);
                    break;
                case 7:
                    Invoke("調藥水8", 0.5f);
                    break;
                case 8:
                    Invoke("調藥水9", 0.5f);
                    break;
                case 9:
                    Invoke("調藥水10", 0.5f);
                    break;
                case 10:
                    Invoke("調藥水11", 0.5f);
                    break;
                case 11:
                    Invoke("調藥水12", 0.5f);
                    break;
                case 12:
                    Invoke("調藥水13", 0.5f);
                    break;
                case 13:
                    Invoke("調藥水14", 0.5f);
                    break;
                case 14:
                    Invoke("調藥水15", 0.5f);
                    break;
                case 15:
                    Invoke("調藥水16", 0.5f);
                    break;
                case 16:
                    Invoke("調藥水17", 0.5f);
                    break;
                case 17:
                    Invoke("調藥水18", 0.5f);
                    break;
                case 18:
                    Invoke("結束", 0.5f);
                    break;
            }


    }

    void 調藥水1()
    {
        進度條1.SetActive(true);
        進度條Bool1 = true;
        T = 1;
        if (SaveData.P1開始調藥水 == false)
        {

        }
        else
            Invoke("調藥水2", 0.5f);


    }
    void 調藥水2()
    {
        T = 2;
        進度條2.SetActive(true);
        進度條Bool2 = true;
        if (SaveData.P1開始調藥水 == false)
        {

        }
        else
            Invoke("調藥水3", 0.5f);

    }

    void 調藥水3()
    {
        T = 3;
        進度條3.SetActive(true);
        進度條Bool3 = true;
        if (SaveData.P1開始調藥水 == false)
        {

        }
        else
            Invoke("調藥水4", 0.5f);

    }

    void 調藥水4()
    {
        T = 4;
        進度條4.SetActive(true);
        進度條Bool4 = true;
        if (SaveData.P1開始調藥水 == false)
        {

        }
        else
            Invoke("調藥水5", 0.5f);

    }
    void 調藥水5()
    {
        T = 5;
        進度條5.SetActive(true);
        進度條Bool5 = true;
        if (SaveData.P1開始調藥水 == false)
        {

        }
        else
            Invoke("調藥水6", 0.5f);

    }

    void 調藥水6()
    {
        T = 6;
        進度條6.SetActive(true);
        進度條Bool6 = true;
        if (SaveData.P1開始調藥水 == false)
        {

        }
        else
            Invoke("調藥水7", 0.5f);

    }

    void 調藥水7()
    {
        T = 7;
        進度條7.SetActive(true);
        進度條Bool7 = true;
        if (SaveData.P1開始調藥水 == false)
        {

        }
        else
            Invoke("調藥水8", 0.5f);

    }

    void 調藥水8()
    {
        T = 8;
        進度條8.SetActive(true);
        進度條Bool8 = true;
        if (SaveData.P1開始調藥水 == false)
        {

        }
        else
            Invoke("調藥水9", 0.5f);

    }

    void 調藥水9()
    {
        T = 9;
        進度條9.SetActive(true);
        進度條Bool9 = true;
        if (SaveData.P1開始調藥水 == false)
        {

        }
        else
            Invoke("調藥水10", 0.5f);

    }

    void 調藥水10()
    {
        T = 10;
        進度條10.SetActive(true);
        進度條Bool10 = true;
        if (SaveData.P1開始調藥水 == false)
        {

        }
        else
            Invoke("調藥水11", 0.5f);

    }

    void 調藥水11()
    {
        T = 11;
        進度條11.SetActive(true);
        進度條Bool11 = true;
        if (SaveData.P1開始調藥水 == false)
        {

        }
        else
            Invoke("調藥水12", 0.5f);

    }

    void 調藥水12()
    {
        T = 12;
        進度條12.SetActive(true);
        進度條Bool12 = true;
        if (SaveData.P1開始調藥水 == false)
        {

        }
        else
            Invoke("調藥水13", 0.5f);

    }

    void 調藥水13()
    {
        T = 13;
        進度條13.SetActive(true);
        進度條Bool13 = true;
        if (SaveData.P1開始調藥水 == false)
        {

        }
        else
            Invoke("調藥水14", 0.5f);

    }

    void 調藥水14()
    {
        T = 14;
        進度條14.SetActive(true);
        進度條Bool14 = true;
        if (SaveData.P1開始調藥水 == false)
        {

        }
        else
            Invoke("調藥水15", 0.5f);

    }

    void 調藥水15()
    {
        T = 15;
        進度條15.SetActive(true);
        進度條Bool15 = true;
        if (SaveData.P1開始調藥水 == false)
        {

        }
        else
            Invoke("調藥水16", 0.5f);

    }

    void 調藥水16()
    {
        T = 16;
        進度條16.SetActive(true);
        進度條Bool16 = true;
        if (SaveData.P1開始調藥水 == false)
        {

        }
        else
            Invoke("調藥水17", 0.5f);

    }

    void 調藥水17()
    {
        T = 17;
        進度條17.SetActive(true);
        進度條Bool17 = true;
        if (SaveData.P1開始調藥水 == false)
        {

        }
        else
            Invoke("調藥水18", 0.5f);

    }

    void 調藥水18()
    {
        T = 18;
        進度條18.SetActive(true);
        進度條Bool18 = true;
        if (SaveData.P1開始調藥水 == false)
        {

        }
        else
            Invoke("結束", 0.5f);

    }
    void 結束()
    {
        SaveData.P1開始調藥水 = false;
        T = 0;
        進度條.SetActive(false);
        進度條1.SetActive(false);
        進度條2.SetActive(false);
        進度條3.SetActive(false);
        進度條4.SetActive(false);
        進度條5.SetActive(false);
        進度條6.SetActive(false);
        進度條7.SetActive(false);
        進度條8.SetActive(false);
        進度條9.SetActive(false);
        進度條10.SetActive(false);
        進度條11.SetActive(false);
        進度條12.SetActive(false);
        進度條13.SetActive(false);
        進度條14.SetActive(false);
        進度條15.SetActive(false);
        進度條16.SetActive(false);
        進度條17.SetActive(false);
        進度條18.SetActive(false);

        進度條Bool1 = false;
        進度條Bool2 = false;
        進度條Bool3 = false;
        進度條Bool4 = false;
        進度條Bool5 = false;
        進度條Bool6 = false;
        進度條Bool7 = false;
        進度條Bool8 = false;
        進度條Bool9 = false;
        進度條Bool10 = false;
        進度條Bool11 = false;
        進度條Bool12 = false;
        進度條Bool13 = false;
        進度條Bool14 = false;
        進度條Bool15 = false;
        進度條Bool16 = false;
        進度條Bool17 = false;
        進度條Bool18 = false;

    }







    public void P2開始調藥水()
    {
        if (T > 0)
        {
            D = T;
            switch (D)
            {
                case 0:
                    進度條.SetActive(true);

                    進度條1.SetActive(true);

                    Invoke("P2調藥水1", 0.5f);
                    break;
                case 1:
                    Invoke("P2調藥水2", 0.5f);
                    break;
                case 2:
                    Invoke("P2調藥水3", 0.5f);
                    break;
                case 3:
                    Invoke("P2調藥水4", 0.5f);
                    break;
                case 4:
                    Invoke("P2調藥水5", 0.5f);
                    break;
                case 5:
                    Invoke("P2調藥水6", 0.5f);
                    break;
                case 6:
                    Invoke("P2調藥水7", 0.5f);
                    break;
                case 7:
                    Invoke("P2調藥水8", 0.5f);
                    break;
                case 8:
                    Invoke("P2調藥水9", 0.5f);
                    break;
                case 9:
                    Invoke("P2調藥水10", 0.5f);
                    break;
                case 10:
                    Invoke("P2調藥水11", 0.5f);
                    break;
                case 11:
                    Invoke("P2調藥水12", 0.5f);
                    break;
                case 12:
                    Invoke("P2調藥水13", 0.5f);
                    break;
                case 13:
                    Invoke("P2調藥水14", 0.5f);
                    break;
                case 14:
                    Invoke("P2調藥水15", 0.5f);
                    break;
                case 15:
                    Invoke("P2調藥水16", 0.5f);
                    break;
                case 16:
                    Invoke("P2調藥水17", 0.5f);
                    break;
                case 17:
                    Invoke("P2調藥水18", 0.5f);
                    break;
                case 18:
                    Invoke("P2結束", 0.5f);
                    break;
            }
        }
        else
            switch (D)
            {
                case 0:
                    進度條.SetActive(true);

                    進度條1.SetActive(true);

                    Invoke("P2調藥水1", 0.5f);
                    break;
                case 1:
                    Invoke("P2調藥水2", 0.5f);
                    break;
                case 2:
                    Invoke("P2調藥水3", 0.5f);
                    break;
                case 3:
                    Invoke("P2調藥水4", 0.5f);
                    break;
                case 4:
                    Invoke("P2調藥水5", 0.5f);
                    break;
                case 5:
                    Invoke("P2調藥水6", 0.5f);
                    break;
                case 6:
                    Invoke("P2調藥水7", 0.5f);
                    break;
                case 7:
                    Invoke("P2調藥水8", 0.5f);
                    break;
                case 8:
                    Invoke("P2調藥水9", 0.5f);
                    break;
                case 9:
                    Invoke("P2調藥水10", 0.5f);
                    break;
                case 10:
                    Invoke("P2調藥水11", 0.5f);
                    break;
                case 11:
                    Invoke("P2調藥水12", 0.5f);
                    break;
                case 12:
                    Invoke("P2調藥水13", 0.5f);
                    break;
                case 13:
                    Invoke("P2調藥水14", 0.5f);
                    break;
                case 14:
                    Invoke("P2調藥水15", 0.5f);
                    break;
                case 15:
                    Invoke("P2調藥水16", 0.5f);
                    break;
                case 16:
                    Invoke("P2調藥水17", 0.5f);
                    break;
                case 17:
                    Invoke("P2調藥水18", 0.5f);
                    break;
                case 18:
                    Invoke("P2結束", 0.5f);
                    break;
            }

    }
    void P2調藥水1()
    {
        進度條1.SetActive(true);
        進度條Bool1 = true;
        D = 1;
        if (SaveData.P2開始調藥水 == false)
        {

        }
        else
            Invoke("P2調藥水2", 0.5f);


    }
    void P2調藥水2()
    {
        D = 2;
        進度條2.SetActive(true);
        進度條Bool2 = true;
        if (SaveData.P2開始調藥水 == false)
        {

        }
        else
            Invoke("P2調藥水3", 0.5f);

    }

    void P2調藥水3()
    {
        D = 3;
        進度條3.SetActive(true);
        進度條Bool3 = true;
        if (SaveData.P2開始調藥水 == false)
        {

        }
        else
            Invoke("P2調藥水4", 0.5f);

    }

    void P2調藥水4()
    {
        D = 4;
        進度條4.SetActive(true);
        進度條Bool4 = true;
        if (SaveData.P2開始調藥水 == false)
        {

        }
        else
            Invoke("P2調藥水5", 0.5f);

    }
    void P2調藥水5()
    {
        D = 5;
        進度條5.SetActive(true);
        進度條Bool5 = true;
        if (SaveData.P2開始調藥水 == false)
        {

        }
        else
            Invoke("P2調藥水6", 0.5f);

    }

    void P2調藥水6()
    {
        D = 6;
        進度條6.SetActive(true);
        進度條Bool6 = true;
        if (SaveData.P2開始調藥水 == false)
        {

        }
        else
            Invoke("P2調藥水7", 0.5f);

    }

    void P2調藥水7()
    {
        D = 7;
        進度條7.SetActive(true);
        進度條Bool7 = true;
        if (SaveData.P2開始調藥水 == false)
        {

        }
        else
            Invoke("P2調藥水8", 0.5f);

    }

    void P2調藥水8()
    {
        D = 8;
        進度條8.SetActive(true);
        進度條Bool8 = true;
        if (SaveData.P2開始調藥水 == false)
        {

        }
        else
            Invoke("P2調藥水9", 0.5f);

    }

    void P2調藥水9()
    {
        D = 9;
        進度條9.SetActive(true);
        進度條Bool9 = true;
        if (SaveData.P2開始調藥水 == false)
        {

        }
        else
            Invoke("P2調藥水10", 0.5f);

    }

    void P2調藥水10()
    {
        D = 10;
        進度條10.SetActive(true);
        進度條Bool10 = true;
        if (SaveData.P2開始調藥水 == false)
        {

        }
        else
            Invoke("P2調藥水11", 0.5f);

    }

    void P2調藥水11()
    {
        D = 11;
        進度條11.SetActive(true);
        進度條Bool11 = true;
        if (SaveData.P2開始調藥水 == false)
        {

        }
        else
            Invoke("P2調藥水12", 0.5f);

    }

    void P2調藥水12()
    {
        D = 12;
        進度條12.SetActive(true);
        進度條Bool12 = true;
        if (SaveData.P2開始調藥水 == false)
        {

        }
        else
            Invoke("P2調藥水13", 0.5f);

    }

    void P2調藥水13()
    {
        D = 13;
        進度條13.SetActive(true);
        進度條Bool13 = true;
        if (SaveData.P2開始調藥水 == false)
        {

        }
        else
            Invoke("P2調藥水14", 0.5f);

    }

    void P2調藥水14()
    {
        D = 14;
        進度條14.SetActive(true);
        進度條Bool14 = true;
        if (SaveData.P2開始調藥水 == false)
        {

        }
        else
            Invoke("P2調藥水15", 0.5f);

    }

    void P2調藥水15()
    {
        D = 15;
        進度條15.SetActive(true);
        進度條Bool15 = true;
        if (SaveData.P2開始調藥水 == false)
        {

        }
        else
            Invoke("P2調藥水16", 0.5f);

    }

    void P2調藥水16()
    {
        D = 16;
        進度條16.SetActive(true);
        進度條Bool16 = true;
        if (SaveData.P2開始調藥水 == false)
        {

        }
        else
            Invoke("P2調藥水17", 0.5f);

    }

    void P2調藥水17()
    {
        D = 17;
        進度條17.SetActive(true);
        進度條Bool17 = true;
        if (SaveData.P2開始調藥水 == false)
        {

        }
        else
            Invoke("P2調藥水18", 0.5f);

    }

    void P2調藥水18()
    {
        D = 18;
        進度條18.SetActive(true);
        進度條Bool18 = true;
        if (SaveData.P2開始調藥水 == false)
        {

        }
        else
            Invoke("P2結束", 0.5f);

    }
    void P2結束()
    {
        D = 0;
        進度條.SetActive(false);
        進度條1.SetActive(false);
        進度條2.SetActive(false);
        進度條3.SetActive(false);
        進度條4.SetActive(false);
        進度條5.SetActive(false);
        進度條6.SetActive(false);
        進度條7.SetActive(false);
        進度條8.SetActive(false);
        進度條9.SetActive(false);
        進度條10.SetActive(false);
        進度條11.SetActive(false);
        進度條12.SetActive(false);
        進度條13.SetActive(false);
        進度條14.SetActive(false);
        進度條15.SetActive(false);
        進度條16.SetActive(false);
        進度條17.SetActive(false);
        進度條18.SetActive(false);

        進度條Bool1 = false;
        進度條Bool2 = false;
        進度條Bool3 = false;
        進度條Bool4 = false;
        進度條Bool5 = false;
        進度條Bool6 = false;
        進度條Bool7 = false;
        進度條Bool8 = false;
        進度條Bool9 = false;
        進度條Bool10 = false;
        進度條Bool11 = false;
        進度條Bool12 = false;
        進度條Bool13 = false;
        進度條Bool14 = false;
        進度條Bool15 = false;
        進度條Bool16 = false;
        進度條Bool17 = false;
        進度條Bool18 = false;

    }
}
