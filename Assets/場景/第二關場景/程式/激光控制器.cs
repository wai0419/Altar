using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 激光控制器 : MonoBehaviour
{
    public ParticleSystem 激光1集氣;
    public ParticleSystem 激光1發射;
    public ParticleSystem 激光2集氣;
    public ParticleSystem 激光2發射;
    public ParticleSystem 激光3集氣;
    public ParticleSystem 激光3發射;

    public GameObject 碰撞器1;
    public GameObject 碰撞器2;
    public GameObject 碰撞器3;

    public int i=0;
    // Start is called before the first frame update
    void Start()
    {
        激光1集氣.Stop();
        激光2集氣.Stop();
        激光3集氣.Stop();
        激光1發射.Stop();
        激光2發射.Stop();
        激光3發射.Stop();
        InvokeRepeating("選擇", 0,15);
    }

    void 選擇()
    {
            i = Random.Range(1, 7);
        
        switch (i)
        {
            case 1:
                激光1集氣.Play();
                Invoke("發射1", 2);        
                break;
            case 2:
                激光2集氣.Play();
                Invoke("發射2", 2);            
                break;
            case 3:
                激光3集氣.Play();
                Invoke("發射3", 2);             
                break;
            case 4:
                激光1集氣.Play();
                Invoke("發射1", 2);
                激光2集氣.Play();
                Invoke("發射2", 2);
                break;
            case 5:
                激光2集氣.Play();
                Invoke("發射2", 2);
                激光3集氣.Play();
                Invoke("發射3", 2);
                break;
            case 6:
                激光1集氣.Play();
                Invoke("發射1", 2);
                激光3集氣.Play();
                Invoke("發射3", 2);
                break;

        }
    }
    void 發射1()
    {
        激光1集氣.Stop();
        激光1發射.Play();
        Invoke("停止發射1", 4);
        碰撞器1.SetActive(true);
    }
    void 發射2()
    {
        激光2集氣.Stop();
        激光2發射.Play();
        Invoke("停止發射2", 4);
        碰撞器2.SetActive(true);
    }
    void 發射3()
    {
        激光3集氣.Stop();
        激光3發射.Play();
        Invoke("停止發射3", 4);
        碰撞器3.SetActive(true);
    }

    void 停止發射1()
    {
        激光1發射.Stop();
        碰撞器1.SetActive(false);

    }
    void 停止發射2()
    {
        激光2發射.Stop();
        碰撞器2.SetActive(false);
    }
    void 停止發射3()
    {
        激光3發射.Stop();
        碰撞器3.SetActive(false);
    }
}
