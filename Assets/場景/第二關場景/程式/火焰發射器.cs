using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 火焰發射器 : MonoBehaviour
{
    public GameObject 碰撞器;
    public int 開啟時間;
    public int i;

    Animator 動畫控制器;

    public ParticleSystem 火焰1;
    public ParticleSystem 火焰2;
    public ParticleSystem 火焰3;
    public ParticleSystem 火焰4;
    public ParticleSystem 火焰5;
    public ParticleSystem 火焰6;

    bool 啟動;
    void Start()
    {
        動畫控制器 = GetComponent<Animator>();
        裝置升高();
        火焰1.Stop();
        火焰2.Stop();
        火焰3.Stop();
        火焰4.Stop();
        火焰5.Stop();
        火焰6.Stop();
    }


    void Update()
    {
        if(啟動==true)
        {
            
            i = Random.Range(1, 3);
            transform.Rotate(0, i, 0);

        }
            
    }
    void 裝置升高()
    {
        動畫控制器.SetBool("開啟", true);
        Invoke("啟動火焰", 5);
    }
    void 啟動火焰()
    {
        碰撞器.SetActive(true);
        啟動 = true;
        火焰1.Play();
        火焰2.Play();
        火焰3.Play();
        火焰4.Play();
        火焰5.Play();
        火焰6.Play();
        Invoke("關閉火焰", 5);
    }

    void 關閉火焰()
    {
        碰撞器.SetActive(false);
        啟動 = false;
        動畫控制器.SetBool("開啟", false);
        火焰1.Stop();
        火焰2.Stop();
        火焰3.Stop();
        火焰4.Stop();
        火焰5.Stop();
        火焰6.Stop();
        開啟時間 = Random.Range(5, 8);
        Invoke("裝置升高", 開啟時間);
    }
}
