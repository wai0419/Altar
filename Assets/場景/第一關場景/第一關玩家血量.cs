using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class 第一關玩家血量 : MonoBehaviour
{
    public Image HPBAR;
    public int i;

    void Start()
    {

        HPBAR.GetComponent<Image>().fillAmount = 1f;
    }
    void Update()
    {
        if (i == 1)
        {
            HPBAR.GetComponent<Image>().fillAmount = SaveData.P1HP; 
        }
        if (i == 2)
        {
            HPBAR.GetComponent<Image>().fillAmount = SaveData.P2HP;
        }
    }
    public void 扣血()
    {
        HPBAR.GetComponent<Image>().fillAmount -= 0.1f;
        Invoke("回血", 5f);
    }
    public void 回血()
    {

        HPBAR.GetComponent<Image>().fillAmount += 0.1f;
    }
}
