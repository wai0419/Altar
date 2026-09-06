using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 裝水 : MonoBehaviour
{
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

    public bool 開始運作;

    public int T;

    public ParticleSystem 水特效;

    public AudioSource 裝水聲;
    // Start is called before the first frame update
    void Start()
    {
        水特效.Stop();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void 正在裝水()
    {
        if (!裝水聲.isPlaying)
        {
            裝水聲.Play();
        }
        水特效.Play();
        開始運作 = true;
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
                Invoke("結束", 0.5f);
                break;


        }

    }
    void 調藥水1()
    {
        進度條1.SetActive(true);
        進度條2.SetActive(true);
        進度條3.SetActive(true);
        進度條4.SetActive(true);

        進度條Bool1 = true;
        T = 1;
        if (SaveData.P1開始調藥水 == false)
        {
            結束2();
        }
        else
            Invoke("調藥水2", 0.5f);


    }

    void 調藥水2()
    {
        T = 2;
        進度條5.SetActive(true);
        進度條6.SetActive(true);
        進度條7.SetActive(true);
        進度條8.SetActive(true);
        進度條Bool2 = true;
        if (SaveData.P1開始調藥水 == false)
        {
            結束2();
        }
        else
            Invoke("調藥水3", 0.5f);

    }

    void 調藥水3()
    {
        T = 3;
        進度條9.SetActive(true);
        進度條10.SetActive(true);
        進度條11.SetActive(true);
        進度條12.SetActive(true);
        進度條Bool3 = true;
        if (SaveData.P1開始調藥水 == false)
        {
            結束2();
        }
        else
            Invoke("調藥水4", 0.5f);

    }

    void 調藥水4()
    {
        T = 4;
        進度條13.SetActive(true);
        進度條14.SetActive(true);
        進度條15.SetActive(true);
        進度條16.SetActive(true);
        進度條Bool4 = true;
        if (SaveData.P1開始調藥水 == false)
        {
            結束2();
        }
        else
            Invoke("調藥水5", 0.5f);

    }

    void 調藥水5()
    {
        T = 5;
        進度條17.SetActive(true);
        進度條18.SetActive(true);
        進度條Bool5 = true;
        if (SaveData.P1開始調藥水 == false)
        {
            結束2();
        }
        else
            Invoke("結束", 0.5f);

    }





    void 結束()
    {

        水特效.Stop();
        SaveData.P1開始裝滿水 = true;


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

    void 結束2()
    {

        裝水聲.Stop();

        水特效.Stop();
        SaveData.鍋子1正在運作 = false;

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
    public void P2正在裝水()
    {
        if (!裝水聲.isPlaying)
        {
            裝水聲.Play();
        }
        水特效.Play();
        開始運作 = true;
        switch (T)
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
                Invoke("P2結束", 0.5f);
                break;


        }

    }
    void P2調藥水1()
    {
        進度條1.SetActive(true);
        進度條2.SetActive(true);
        進度條3.SetActive(true);
        進度條4.SetActive(true);

        進度條Bool1 = true;
        T = 1;
        if (SaveData.P2開始調藥水 == false)
        {
            結束2();
        }
        else
            Invoke("P2調藥水2", 0.5f);


    }

    void P2調藥水2()
    {
        T = 2;
        進度條5.SetActive(true);
        進度條6.SetActive(true);
        進度條7.SetActive(true);
        進度條8.SetActive(true);
        進度條Bool2 = true;
        if (SaveData.P2開始調藥水 == false)
        {
            結束2();
        }
        else
            Invoke("P2調藥水3", 0.5f);

    }

    void P2調藥水3()
    {
        T = 3;
        進度條9.SetActive(true);
        進度條10.SetActive(true);
        進度條11.SetActive(true);
        進度條12.SetActive(true);
        進度條Bool3 = true;
        if (SaveData.P2開始調藥水 == false)
        {
            結束2();
        }
        else
            Invoke("P2調藥水4", 0.5f);

    }

    void P2調藥水4()
    {
        T = 4;
        進度條13.SetActive(true);
        進度條14.SetActive(true);
        進度條15.SetActive(true);
        進度條16.SetActive(true);
        進度條Bool4 = true;
        if (SaveData.P2開始調藥水 == false)
        {
            結束2();
        }
        else
            Invoke("P2調藥水5", 0.5f);

    }

    void P2調藥水5()
    {
        T = 5;
        進度條17.SetActive(true);
        進度條18.SetActive(true);
        進度條Bool5 = true;
        if (SaveData.P2開始調藥水 == false)
        {
            結束2();
        }
        else
            Invoke("P2結束", 0.5f);

    }





    void P2結束()
    {
        水特效.Stop();
        SaveData.P2開始裝滿水 = true;


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
}
