using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class 跳轉 : MonoBehaviour
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
        if (動畫控制器.GetCurrentAnimatorStateInfo(0).IsName("結束"))
        {

            Invoke("MethodName", 2);
        }
    }
    void MethodName()
    {
        SceneManager.LoadScene(1);
    }
}
