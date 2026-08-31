using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 跳轉畫面縮小 : MonoBehaviour
{
    Animator 動畫控制器;

    void Start()
    {
        動畫控制器 = GetComponent<Animator>();
        Invoke("結束", 1f);
    }

    void 結束()
    {
        this.gameObject.SetActive(false);
    }
}
