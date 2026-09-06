using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 相機移動 : MonoBehaviour
{
    public float dist;

    public AudioSource a;

    public GameObject P1角色;

    public GameObject P2角色;

    public GameObject 鍵盤右P1;
    public GameObject 鍵盤右P2;


    public GameObject 鍵盤左P1;
    public GameObject 鍵盤左P2;



    public GameObject P1復活點;

    public GameObject P2復活點;



    public ParticleSystem P1復活特效;

    public ParticleSystem P2復活特效;
    // Start is called before the first frame update
    void Start()
    {
        a.volume = SaveData.音量;

        P1復活特效.Stop();

        P2復活特效.Stop();
    }

    // Update is called once per frame
    void Update()
    {

        //P1
        
        if (SaveData.P1HP <= 0)
        {
            Destroy(GameObject.FindWithTag("Player"));

            SaveData.P1HP = 2;
            Invoke("復活P1", 7f);
            
        }



        //P2
        
        if (SaveData.P2HP <= 0)
        {
            Destroy(GameObject.FindWithTag("P2"));

            SaveData.P2HP = 2;
            Invoke("復活P2", 7f);
            
        }

    }
    void FixedUpdate()
    {
        if (GameObject.FindWithTag("Player") == false)
        {
            Vector3 位置 = new Vector3(GameObject.FindWithTag("P2").transform.position.x, 25, GameObject.FindWithTag("P2").transform.position.z);
            transform.position = Vector3.Lerp(transform.position, 位置, 5 * Time.deltaTime);
        }
        if (GameObject.FindWithTag("P2") == false)
        {
            Vector3 位置 = new Vector3(GameObject.FindWithTag("Player").transform.position.x, 25, GameObject.FindWithTag("Player").transform.position.z);
            transform.position = Vector3.Lerp(transform.position, 位置, 5 * Time.deltaTime);
        }
        if (GameObject.FindWithTag("Player") == true && GameObject.FindWithTag("P2") == true)
        {
            Vector3 位置 = new Vector3((GameObject.FindWithTag("Player").transform.position.x + GameObject.FindWithTag("P2").transform.position.x) / 2, 25, (GameObject.FindWithTag("Player").transform.position.z + GameObject.FindWithTag("P2").transform.position.z) / 2);
            transform.position = Vector3.Lerp(transform.position, 位置, 5 * Time.deltaTime);
        }

    }
    void 復活P1()
    {
        if(SaveData.遊戲結束==false)
        {
            SaveData.P1HP = 1;
            
            P1復活特效.Play();
            if (SaveData.鍵盤右 > SaveData.鍵盤左)
            {
                switch (SaveData.鍵盤左)
                {
                    case 1:
                        Debug.Log("11111111111");
                        Instantiate(鍵盤左P1, P1復活點.transform.position, Quaternion.identity);
                        break;
                    case 2:
                        Debug.Log("222222222222");
                        Instantiate(鍵盤左P2, P2復活點.transform.position, Quaternion.identity);
                        break;
                }
            }
            if (SaveData.鍵盤右 < SaveData.鍵盤左)
            {
                switch (SaveData.鍵盤右)
                {
                    case 1:
                        Debug.Log("3333333333");
                        Instantiate(鍵盤右P1, P1復活點.transform.position, Quaternion.identity);
                        break;
                    case 2:
                        Debug.Log("44444444444");
                        Instantiate(鍵盤右P2, P2復活點.transform.position, Quaternion.identity);
                        break;
                }
            }

        }
        
    }

    void 復活P2()
    {
        if (SaveData.遊戲結束 == false)
        {
            if (SaveData.鍵盤右 > SaveData.鍵盤左)
            {
                switch (SaveData.鍵盤右)
                {
                    case 1:

                        Instantiate(鍵盤右P1, P1復活點.transform.position, Quaternion.identity);
                        break;
                    case 2:

                        Instantiate(鍵盤右P2, P2復活點.transform.position, Quaternion.identity);
                        break;
                }
            }
            if (SaveData.鍵盤右 < SaveData.鍵盤左)
            {
                switch (SaveData.鍵盤左)
                {
                    case 1:

                        Instantiate(鍵盤左P1, P1復活點.transform.position, Quaternion.identity);
                        break;
                    case 2:

                        Instantiate(鍵盤左P2, P2復活點.transform.position, Quaternion.identity);
                        break;
                }
            }
            SaveData.P2HP = 1;



            P2復活特效.Play();
        }
    }
}
