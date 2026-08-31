using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 祭壇 : MonoBehaviour
{
    public GameObject 吸血鬼;

    public GameObject 石化吸血鬼;

    public bool 顯示吸血鬼=false;

    public bool 顯示石化吸血鬼=false;

    public GameObject 幽靈;

    public GameObject 石化幽靈;

    public bool 顯示幽靈 = false;

    public bool 顯示石化幽靈 = false;



    public bool 是否有怪物;

    public ParticleSystem 橘藥水;

    public ParticleSystem 綠藥水;

    public int NO;

    public bool 運作中;
    // Start is called before the first frame update
    void Start()
    {
        橘藥水.Stop();

        綠藥水.Stop();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void 拿敵人()//吸血鬼
    {
        if (NO == 1)
        {
            SaveData.祭壇一有怪物 = false;
            是否有怪物 = false;
        }
        if (NO == 2)
        {
            SaveData.祭壇二有怪物 = false;
            是否有怪物 = false;
        }
        if (NO == 3)
        {
            SaveData.祭壇三有怪物 = false;
            是否有怪物 = false;
        }
        吸血鬼.SetActive(false);
        顯示吸血鬼 = false;
    }

    public void 拿石化吸血鬼()
    {
        if (NO == 1)
        {
            SaveData.祭壇一有怪物 = false;
            是否有怪物 = false;
        }
        if (NO == 2)
        {
            SaveData.祭壇二有怪物 = false;
            是否有怪物 = false;
        }
        if (NO == 3)
        {
            SaveData.祭壇三有怪物 = false;
            是否有怪物 = false;
        }
        石化吸血鬼.SetActive(false);
        顯示石化吸血鬼 = false;
    }
    public void 放敵人()
    {
        if(NO==1)
        {
            SaveData.祭壇一有怪物 = true;
            是否有怪物 = true;
        }
        if (NO == 2)
        {
            SaveData.祭壇二有怪物 = true;
            是否有怪物 = true;
        }
        if (NO == 3)
        {
            SaveData.祭壇三有怪物 = true;
            是否有怪物 = true;
        }
        吸血鬼.SetActive(true);
        顯示吸血鬼 = true;

    }

    public void 拿幽靈()//幽靈
    {
        if (NO == 1)
        {
            SaveData.祭壇一有怪物 = false;
            是否有怪物 = false;
        }
        if (NO == 2)
        {
            SaveData.祭壇二有怪物 = false;
            是否有怪物 = false;
        }
        if (NO == 3)
        {
            SaveData.祭壇三有怪物 = false;
            是否有怪物 = false;
        }
        幽靈.SetActive(false);
        顯示幽靈 = false;
    }

    public void 拿石化幽靈()
    {
        if (NO == 1)
        {
            SaveData.祭壇一有怪物 = false;
            是否有怪物 = false;
        }
        if (NO == 2)
        {
            SaveData.祭壇二有怪物 = false;
            是否有怪物 = false;
        }
        if (NO == 3)
        {
            SaveData.祭壇三有怪物 = false;
            是否有怪物 = false;
        }
        石化幽靈.SetActive(false);
        顯示石化幽靈 = false;
    }
    public void 放幽靈()
    {
        if (NO == 1)
        {
            SaveData.祭壇一有怪物 = true;
            是否有怪物 = true;
        }
        if (NO == 2)
        {
            SaveData.祭壇二有怪物 = true;
            是否有怪物 = true;
        }
        if (NO == 3)
        {
            SaveData.祭壇三有怪物 = true;
            是否有怪物 = true;
        }
        幽靈.SetActive(true);
        顯示幽靈 = true;

    }
    public void 灑藥水效果()
    {
        橘藥水.Play();
        吸血鬼.SetActive(false);
        石化吸血鬼.SetActive(true);
        顯示石化吸血鬼 = true;
        顯示吸血鬼 = false;
    }

    public void 石化幽靈效果()
    {
        綠藥水.Play();
        幽靈.SetActive(false);
        石化幽靈.SetActive(true);
        顯示石化幽靈 = true;
        顯示幽靈 = false;
    }
}
