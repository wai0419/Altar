using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 暫停畫面 : MonoBehaviour
{
    Animator 動畫控制器;
    // Start is called before the first frame update
    void Start()
    {
        動畫控制器 = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(SaveData.暫停==true)
        {
            動畫控制器.SetBool("開始", true);
        }
        if (SaveData.暫停 == false)
        {
            動畫控制器.SetBool("開始", false);
        }
    }
}
