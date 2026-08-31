using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 講台 : MonoBehaviour
{
    //第一關講台
    public GameObject 大蒜;

    public GameObject 鹽巴;

    public GameObject 水;

    public GameObject 大蒜和水;

    public GameObject 鹽巴和水;

    public bool 是否顯示大蒜;

    public bool 是否顯示鹽巴;

    public bool 是否顯示水;

    public bool 是否顯示大蒜和水;

    public bool 是否顯示鹽巴和水;

    public bool 開始運作;

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

    public GameObject 大蒜藥水;

    public GameObject 鹽巴藥水;

    public bool 已生成大蒜藥水 = false;

    public bool 已生成鹽巴藥水 = false;

    public ParticleSystem 完成特效;

    public AudioSource 調藥水聲;

    public void Start()
    {
        完成特效.Stop();
    }
    public void 顯示大蒜()
    {
        大蒜.SetActive(true);
        是否顯示大蒜 = true;
    }

    public void 顯示鹽巴()
    {
        鹽巴.SetActive(true);
        是否顯示鹽巴 = true;
    }

    public void 顯示水()
    {
        水.SetActive(true);
        是否顯示水 = true;
    }
    public void 顯示鹽巴和水()
    {
        鹽巴和水.SetActive(true);
        是否顯示鹽巴和水 = true;
        鹽巴.SetActive(false);
        水.SetActive(false);
        是否顯示鹽巴 = true;
        是否顯示水 = true;
    }
    public void 顯示大蒜和水()
    {
        大蒜和水.SetActive(true);
        是否顯示大蒜和水 = true;
        水.SetActive(false);
        大蒜.SetActive(false);
        是否顯示水 = true;
        是否顯示大蒜 = true;
    }
    public void 製作魔藥()
    {
        if (!調藥水聲.isPlaying)
        {
            調藥水聲.Play();
        }
        完成特效.Play();
        鹽巴和水.SetActive(false);
        大蒜和水.SetActive(false);
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
                Invoke("結束", 0.5f);
                break;
           
        }

    }
    void 調藥水1()
    {
        進度條1.SetActive(true);
        進度條2.SetActive(true);
        進度條Bool1 = true;
        T = 1;
        if (SaveData.P1開始調藥水 == false)
        {
            完成特效.Stop();
            調藥水聲.Stop();
        }
        else
            Invoke("調藥水2", 0.5f);


    }

    void 調藥水2()
    {
        T = 2;
        進度條3.SetActive(true);
        進度條4.SetActive(true);
        進度條Bool2 = true;
        if (SaveData.P1開始調藥水 == false)
        {
            完成特效.Stop();
            調藥水聲.Stop();
        }
        else
            Invoke("調藥水3", 0.5f);

    }

    void 調藥水3()
    {
        T = 3;
        進度條5.SetActive(true);
        進度條6.SetActive(true);
        進度條Bool3 = true;
        if (SaveData.P1開始調藥水 == false)
        {
            完成特效.Stop();
            調藥水聲.Stop();
        }
        else
            Invoke("調藥水4", 0.5f);

    }

    void 調藥水4()
    {
        T = 4;
        進度條7.SetActive(true);
        進度條8.SetActive(true);
        進度條Bool4 = true;
        if (SaveData.P1開始調藥水 == false)
        {
            完成特效.Stop();
            調藥水聲.Stop();
        }
        else
            Invoke("調藥水5", 0.5f);

    }

    void 調藥水5()
    {
        T = 5;
        進度條9.SetActive(true);
        進度條10.SetActive(true);
        進度條Bool5 = true;
        if (SaveData.P1開始調藥水 == false)
        {
            完成特效.Stop();
            調藥水聲.Stop();
        }
        else
            Invoke("調藥水6", 0.5f);

    }

    void 調藥水6()
    {
        T = 6;
        進度條11.SetActive(true);
        進度條12.SetActive(true);
        進度條Bool6 = true;
        if (SaveData.P1開始調藥水 == false)
        {
            完成特效.Stop();
            調藥水聲.Stop();
        }
        else
            Invoke("調藥水7", 0.5f);

    }

    void 調藥水7()
    {
        T = 7;
        進度條13.SetActive(true);
        進度條14.SetActive(true);
        進度條Bool7 = true;
        if (SaveData.P1開始調藥水 == false)
        {
            完成特效.Stop();
            調藥水聲.Stop();
        }
        else
            Invoke("調藥水8", 0.5f);

    }

    void 調藥水8()
    {
        T = 8;
        進度條15.SetActive(true);
        進度條16.SetActive(true);
        進度條Bool8 = true;
        if (SaveData.P1開始調藥水 == false)
        {
            完成特效.Stop();
            調藥水聲.Stop();
        }
        else
            Invoke("調藥水9", 0.5f);

    }

    void 調藥水9()
    {
        T = 9;
        進度條17.SetActive(true);
        進度條18.SetActive(true);
        進度條Bool9 = true;
        if (SaveData.P1開始調藥水 == false)
        {
            完成特效.Stop();
            調藥水聲.Stop();
        }
        else
            Invoke("結束", 0.5f);

    }

    
    public void 重新()
    {
        鹽巴藥水.SetActive(false);

        大蒜藥水.SetActive(false);

    }
    void 結束()
    {
        調藥水聲.Stop();
        完成特效.Stop();
        if (是否顯示鹽巴和水 == true)
        {
            鹽巴藥水.SetActive(true);
            是否顯示鹽巴和水 = false;
            已生成鹽巴藥水 = true;
        }
        if (是否顯示大蒜和水 == true)
        {
            大蒜藥水.SetActive(true);
            是否顯示大蒜和水 = false;
            已生成大蒜藥水 = true;
        }

        是否顯示鹽巴和水 = false;
        是否顯示鹽巴 = false;
        是否顯示大蒜和水 = false;
        是否顯示大蒜 = false;
        是否顯示水 = false;

        開始運作 = false;

        SaveData.鍋子1正在運作 = false;
        SaveData.鍋子1生成藥水 = true;
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


    public void P2製作魔藥()
    {
        if (!調藥水聲.isPlaying)
        {
            調藥水聲.Play();
        }
        完成特效.Play();
        鹽巴和水.SetActive(false);
        大蒜和水.SetActive(false);
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
                Invoke("P2結束", 0.5f);
                break;

        }

    }
    void P2調藥水1()
    {
        進度條1.SetActive(true);
        進度條2.SetActive(true);
        進度條Bool1 = true;
        T = 1;
        if (SaveData.P2開始調藥水 == false)
        {
            完成特效.Stop();
            調藥水聲.Stop();
        }
        else
            Invoke("P2調藥水2", 0.5f);


    }

    void P2調藥水2()
    {
        T = 2;
        進度條3.SetActive(true);
        進度條4.SetActive(true);
        進度條Bool2 = true;
        if (SaveData.P2開始調藥水 == false)
        {
            完成特效.Stop();
            調藥水聲.Stop();
        }
        else
            Invoke("P2調藥水3", 0.5f);

    }

    void P2調藥水3()
    {
        T = 3;
        進度條5.SetActive(true);
        進度條6.SetActive(true);
        進度條Bool3 = true;
        if (SaveData.P2開始調藥水 == false)
        {
            完成特效.Stop();
            調藥水聲.Stop();
        }
        else
            Invoke("P2調藥水4", 0.5f);

    }

    void P2調藥水4()
    {
        T = 4;
        進度條7.SetActive(true);
        進度條8.SetActive(true);
        進度條Bool4 = true;
        if (SaveData.P2開始調藥水 == false)
        {
            完成特效.Stop();
            調藥水聲.Stop();
        }
        else
            Invoke("P2調藥水5", 0.5f);

    }

    void P2調藥水5()
    {
        T = 5;
        進度條9.SetActive(true);
        進度條10.SetActive(true);
        進度條Bool5 = true;
        if (SaveData.P2開始調藥水 == false)
        {
            完成特效.Stop();
            調藥水聲.Stop();
        }
        else
            Invoke("P2調藥水6", 0.5f);

    }

    void P2調藥水6()
    {
        T = 6;
        進度條11.SetActive(true);
        進度條12.SetActive(true);
        進度條Bool6 = true;
        if (SaveData.P2開始調藥水 == false)
        {
            完成特效.Stop();
            調藥水聲.Stop();
        }
        else
            Invoke("P2調藥水7", 0.5f);

    }

    void P2調藥水7()
    {
        T = 7;
        進度條13.SetActive(true);
        進度條14.SetActive(true);
        進度條Bool7 = true;
        if (SaveData.P2開始調藥水 == false)
        {
            完成特效.Stop();
            調藥水聲.Stop();
        }
        else
            Invoke("P2調藥水8", 0.5f);

    }

    void P2調藥水8()
    {
        T = 8;
        進度條15.SetActive(true);
        進度條16.SetActive(true);
        進度條Bool8 = true;
        if (SaveData.P2開始調藥水 == false)
        {
            完成特效.Stop();
            調藥水聲.Stop();
        }
        else
            Invoke("P2調藥水9", 0.5f);

    }

    void P2調藥水9()
    {
        T = 9;
        進度條17.SetActive(true);
        進度條18.SetActive(true);
        進度條Bool9 = true;
        if (SaveData.P2開始調藥水 == false)
        {
            完成特效.Stop();
            調藥水聲.Stop();
        }
        else
            Invoke("P2結束", 0.5f);

    }

    void P2結束()
    {
        調藥水聲.Stop();
        完成特效.Stop();
        if (是否顯示鹽巴和水 == true)
        {
            鹽巴藥水.SetActive(true);
            是否顯示鹽巴和水 = false;
            已生成鹽巴藥水 = true;
        }
        if (是否顯示大蒜和水 == true)
        {
            大蒜藥水.SetActive(true);
            是否顯示大蒜和水 = false;
            已生成大蒜藥水 = true;
        }

        是否顯示鹽巴和水 = false;
        是否顯示鹽巴 = false;
        是否顯示大蒜和水 = false;
        是否顯示大蒜 = false;
        是否顯示水 = false;

        開始運作 = false;

        SaveData.鍋子1正在運作 = false;
        SaveData.鍋子1生成藥水 = true;
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

