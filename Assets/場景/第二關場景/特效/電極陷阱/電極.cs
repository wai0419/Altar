using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 電極 : MonoBehaviour
{
    Animator 動畫控制器;
    public bool 開啟;

    BoxCollider BC;
    // Start is called before the first frame update
    void Start()
    {
        動畫控制器 = GetComponent<Animator>();

        BC = GetComponent<BoxCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        if(開啟==true)
        {
            Invoke("準備電擊", 2);
            開啟 = false;        }
    }
    void 準備電擊()
    {
        動畫控制器.SetBool("準備電擊", true);
        Invoke("電擊", 6);

    }
    void 電擊()
    {
        動畫控制器.SetBool("電擊中", true);
        BC.enabled = true;
        Invoke("電擊完", 3);
    }
    void 電擊完()
    {
        BC.enabled = false;
        動畫控制器.SetBool("準備電擊", false);
        動畫控制器.SetBool("電擊中", false);

    }
}
