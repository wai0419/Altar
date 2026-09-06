using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 地圖二右鍵盤針筒 : MonoBehaviour
{
    //地圖二左控制P2(針筒)

    public GameObject 針筒發射位置;

    public Rigidbody 針筒;

    private Rigidbody playerBody;

    private Vector3 inputVector;

    public float Speed = 2f;

    Animator 動畫控制器;

    public GameObject 武器;

    public GameObject 針;

    public GameObject AED;

    public GameObject 鋸子;

    public GameObject 繃帶;

    public GameObject 手上的針;

    public GameObject 手上的AED;

    public GameObject 手上的鋸子;

    public GameObject 手上的繃帶;

    public GameObject 手上的實驗體1;

    public GameObject 手上的實驗熊;

    public GameObject 手上的實驗輪椅;

    public GameObject 手上的支解實驗體1;

    public GameObject 手上的支解實驗熊;

    public GameObject 手上的支解實驗輪椅;

    public GameObject 放下位置;

    public int 拾取計數器 = 1;

    public bool 是否拿起針 = false;

    public bool 是否拿起AED = false;

    public bool 是否拿起鋸子 = false;

    public bool 是否拿起繃帶 = false;

    public bool 是否拿起實驗體1 = false;

    public bool 是否拿起實驗熊 = false;

    public bool 是否拿起實驗輪椅 = false;

    public bool 是否拿起支解實驗體1 = false;

    public bool 是否拿起支解實驗熊 = false;

    public bool 是否拿起支解實驗輪椅 = false;


    public AudioSource 走路聲;

    public AudioSource 攻擊聲;

    public AudioSource 撿;

    public AudioSource 丟;
    void Start()
    {


        動畫控制器 = GetComponent<Animator>();

        playerBody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        inputVector = new Vector3(Input.GetAxis("Horizontal") * Speed, playerBody.linearVelocity.y, Input.GetAxis("Vertical") * Speed);
        transform.LookAt(transform.position + new Vector3(inputVector.x, 0, inputVector.z));

        if (Input.GetAxis("Horizontal") != 0 || Input.GetAxis("Vertical") != 0)
        {
            
            動畫控制器.SetBool("跑步", true);
            if (!走路聲.isPlaying)
            {
                走路聲.Play();
            }
        }
        if (Input.GetAxis("Horizontal") == 0 && Input.GetAxis("Vertical") == 0)
        {
            動畫控制器.SetBool("跑步", false);
        }
        丟東西();


        //攻擊
        if (Input.GetKeyDown(KeyCode.RightControl) && SaveData.P2攻擊中 == false&&是否拿起針==false && 是否拿起AED == false && 是否拿起鋸子 == false && 是否拿起繃帶 == false && 是否拿起實驗體1 == false && 是否拿起實驗熊 == false && 是否拿起實驗輪椅 == false)
        {


            Rigidbody clone;
            clone = Instantiate(針筒, 放下位置.transform.position, 放下位置.transform.rotation) as Rigidbody;
            clone.linearVelocity = transform.TransformDirection(Vector3.forward * 10);



            動畫控制器.SetBool("攻擊", true);
        }



        if (動畫控制器.GetCurrentAnimatorStateInfo(0).IsName("攻擊"))
        {
            動畫控制器.SetBool("攻擊", false);
            SaveData.P2攻擊中 = true;
            Speed = 0;
        }
        if (!動畫控制器.GetCurrentAnimatorStateInfo(0).IsName("攻擊"))
        {

            SaveData.P2攻擊中 = false;
            Speed = 3.5f;
        }
    }
    private void FixedUpdate()
    {
        playerBody.linearVelocity = inputVector;
    }

    private void OnTriggerStay(Collider col)
    {
        if (col.tag == "發光")
        {
            var 發光程式 = col.GetComponent<發光程式>();
            if (發光程式 != null)
            {
                發光程式.發光();
            }
        }
        if (col.tag == "箱子" && Input.GetKey(KeyCode.RightShift))
        {
            var 箱子程式 = col.GetComponent<箱子>();
            if (箱子程式 != null)
            {
                switch (箱子程式.第幾個箱子)
                {
                    case 1:

                        武器.SetActive(false);
                        是否拿起繃帶 = true;
                        Invoke("D0", 0.1f);
                        手上的繃帶.SetActive(true);
                        if (!撿.isPlaying)
                        {
                            撿.Play();
                        }
                        break;
                    case 2:
                        武器.SetActive(false);
                        是否拿起AED = true;
                        Invoke("D0", 0.1f);
                        手上的AED.SetActive(true);
                        if (!撿.isPlaying)
                        {
                            撿.Play();
                        }
                        break;
                    case 3:

                        武器.SetActive(false);
                        是否拿起針 = true;
                        Invoke("D0", 0.1f);
                        手上的針.SetActive(true);
                        if (!撿.isPlaying)
                        {
                            撿.Play();
                        }
                        break;
                    case 4:

                        武器.SetActive(false);
                        是否拿起鋸子 = true;
                        Invoke("D0", 0.1f);
                        手上的鋸子.SetActive(true);
                        if (!撿.isPlaying)
                        {
                            撿.Play();
                        }
                        break;
                }
            }


        }
        if (col.tag == "針" && Input.GetKey(KeyCode.RightShift) && 拾取計數器 == 1 && 是否拿起針 == false)
        {
            if (!撿.isPlaying)
            {
                撿.Play();
            }
            武器.SetActive(false);
            是否拿起針 = true;
            Invoke("D0", 0.1f);
            手上的針.SetActive(true);
            Destroy(col.gameObject);
        }
        if (col.tag == "AED" && Input.GetKey(KeyCode.RightShift) && 拾取計數器 == 1 && 是否拿起AED == false)
        {
            if (!撿.isPlaying)
            {
                撿.Play();
            }
            武器.SetActive(false);
            是否拿起AED = true;
            Invoke("D0", 0.1f);
            手上的AED.SetActive(true);
            Destroy(col.gameObject);
        }
        if (col.tag == "鋸子" && Input.GetKey(KeyCode.RightShift) && 拾取計數器 == 1 && 是否拿起鋸子 == false)
        {
            if (!撿.isPlaying)
            {
                撿.Play();
            }
            武器.SetActive(false);
            是否拿起鋸子 = true;
            Invoke("D0", 0.1f);
            手上的鋸子.SetActive(true);
            Destroy(col.gameObject);
        }
        if (col.tag == "繃帶" && Input.GetKey(KeyCode.RightShift) && 拾取計數器 == 1 && 是否拿起繃帶 == false)
        {
            if (!撿.isPlaying)
            {
                撿.Play();
            }
            武器.SetActive(false);
            是否拿起繃帶 = true;
            Invoke("D0", 0.1f);
            手上的繃帶.SetActive(true);
            Destroy(col.gameObject);
        }

        if (col.tag == "實驗體X33" && Input.GetKey(KeyCode.RightShift) && 拾取計數器 == 1 && 是否拿起實驗體1 == false)
        {
            if (!撿.isPlaying)
            {
                撿.Play();
            }
            武器.SetActive(false);
            Debug.Log("111111111111111111111110");
            是否拿起實驗體1 = true;
            Invoke("D0", 0.1f);
            手上的實驗體1.SetActive(true);
            Destroy(col.gameObject);
        }

        if (col.tag == "實驗熊" && Input.GetKey(KeyCode.RightShift) && 拾取計數器 == 1 && 是否拿起實驗熊 == false)
        {
            if (!撿.isPlaying)
            {
                撿.Play();
            }
            武器.SetActive(false);
            Debug.Log("111111111111111111111110");
            是否拿起實驗熊 = true;
            Invoke("D0", 0.1f);
            手上的實驗熊.SetActive(true);
            Destroy(col.gameObject);
        }

        if (col.tag == "實驗輪椅" && Input.GetKey(KeyCode.RightShift) && 拾取計數器 == 1 && 是否拿起實驗輪椅 == false)
        {
            if (!撿.isPlaying)
            {
                撿.Play();
            }
            武器.SetActive(false);
            Debug.Log("111111111111111111111110");
            是否拿起實驗輪椅 = true;
            Invoke("D0", 0.1f);
            手上的實驗輪椅.SetActive(true);
            Destroy(col.gameObject);
        }

        //////////////////////////////////////////////實驗體
        if (col.tag == "醫療椅" && Input.GetKey(KeyCode.RightShift) && 拾取計數器 == 0 && 是否拿起實驗體1 == true && col.GetComponent<醫療椅>().是否有實驗體在上面 == false && col.GetComponent<醫療椅>().是否有怪物在上面 == false)
        {
            武器.SetActive(true);
            col.GetComponent<醫療椅>().是否有實驗體在上面 = true;
            col.GetComponent<醫療椅>().是否有怪物在上面 = true;
            var EMHP = col.GetComponent<醫療椅>();
            EMHP.顯示實驗體1();
            是否拿起實驗體1 = false;
            手上的實驗體1.SetActive(false);
            Invoke("D1", 0.1f);
        }
        if (col.tag == "醫療椅" && Input.GetKey(KeyCode.RightControl) && 是否拿起鋸子 == true && col.GetComponent<醫療椅>().是否有實驗體在上面 == true)
        {
            var EMHP = col.GetComponent<醫療椅>();
            EMHP.支解怪物();
        }
        if (col.tag == "醫療椅" && Input.GetKey(KeyCode.RightControl) && 是否拿起繃帶 == true && col.GetComponent<醫療椅>().是否有實驗體在上面 == true && col.GetComponent<醫療椅>().支解完成 == true)
        {
            var EMHP = col.GetComponent<醫療椅>();
            EMHP.繃帶支解怪物();
        }
        if (col.tag == "醫療椅" && Input.GetKey(KeyCode.RightShift) && 拾取計數器 == 1 && col.GetComponent<醫療椅>().是否有實驗體在上面 == true && col.GetComponent<醫療椅>().繃帶處理完成 == true)
        {
            if (!撿.isPlaying)
            {
                撿.Play();
            }
            武器.SetActive(false);
            Invoke("D0", 0.1f);
            是否拿起支解實驗體1 = true;
            col.GetComponent<醫療椅>().是否有實驗體在上面 = false;
            col.GetComponent<醫療椅>().是否有怪物在上面 = false;
            var EMHP = col.GetComponent<醫療椅>();
            EMHP.消失();
            手上的支解實驗體1.SetActive(true);
        }

        //////////////////////////////////////////////實驗熊
        if (col.tag == "醫療椅" && Input.GetKey(KeyCode.RightShift) && 拾取計數器 == 0 && 是否拿起實驗熊 == true && col.GetComponent<醫療椅>().是否有實驗熊在上面 == false && col.GetComponent<醫療椅>().是否有怪物在上面 == false)
        {
            武器.SetActive(true);
            col.GetComponent<醫療椅>().是否有實驗熊在上面 = true;
            col.GetComponent<醫療椅>().是否有怪物在上面 = true;
            var EMHP = col.GetComponent<醫療椅>();
            EMHP.顯示實驗熊();
            是否拿起實驗熊 = false;
            手上的實驗熊.SetActive(false);
            Invoke("D1", 0.1f);
        }
        if (col.tag == "醫療椅" && Input.GetKey(KeyCode.RightControl) && 是否拿起針 == true && col.GetComponent<醫療椅>().是否有實驗熊在上面 == true)
        {
            var EMHP = col.GetComponent<醫療椅>();
            EMHP.支解實驗熊();
        }
        if (col.tag == "醫療椅" && Input.GetKey(KeyCode.RightControl) && 是否拿起繃帶 == true && col.GetComponent<醫療椅>().是否有實驗熊在上面 == true && col.GetComponent<醫療椅>().支解完成 == true)
        {
            var EMHP = col.GetComponent<醫療椅>();
            EMHP.繃帶支解實驗熊();
        }
        if (col.tag == "醫療椅" && Input.GetKey(KeyCode.RightShift) && 拾取計數器 == 1 && col.GetComponent<醫療椅>().是否有實驗熊在上面 == true && col.GetComponent<醫療椅>().繃帶處理完成 == true)
        {
            if (!撿.isPlaying)
            {
                撿.Play();
            }
            武器.SetActive(false);
            Invoke("D0", 0.1f);
            是否拿起支解實驗熊 = true;
            col.GetComponent<醫療椅>().是否有實驗體在上面 = false;
            col.GetComponent<醫療椅>().是否有怪物在上面 = false;
            var EMHP = col.GetComponent<醫療椅>();
            EMHP.消失實驗熊();
            手上的支解實驗熊.SetActive(true);
        }

        //////////////////////////////////////////////實驗輪椅
        if (col.tag == "醫療椅" && Input.GetKey(KeyCode.RightShift) && 拾取計數器 == 0 && 是否拿起實驗輪椅 == true && col.GetComponent<醫療椅>().是否有實驗輪椅在上面 == false && col.GetComponent<醫療椅>().是否有怪物在上面 == false)
        {
            武器.SetActive(true);
            col.GetComponent<醫療椅>().是否有實驗輪椅在上面 = true;
            col.GetComponent<醫療椅>().是否有怪物在上面 = true;
            var EMHP = col.GetComponent<醫療椅>();
            EMHP.顯示實驗輪椅();
            是否拿起實驗輪椅 = false;
            手上的實驗輪椅.SetActive(false);
            Invoke("D1", 0.1f);
        }
        if (col.tag == "醫療椅" && Input.GetKey(KeyCode.RightControl) && 是否拿起AED == true && col.GetComponent<醫療椅>().是否有實驗輪椅在上面 == true)
        {
            var EMHP = col.GetComponent<醫療椅>();
            EMHP.支解實驗輪椅();
        }
        if (col.tag == "醫療椅" && Input.GetKey(KeyCode.RightControl) && 是否拿起繃帶 == true && col.GetComponent<醫療椅>().是否有實驗輪椅在上面 == true && col.GetComponent<醫療椅>().支解完成 == true)
        {
            var EMHP = col.GetComponent<醫療椅>();
            EMHP.繃帶支解實驗輪椅();
        }
        if (col.tag == "醫療椅" && Input.GetKey(KeyCode.RightShift) && 拾取計數器 == 1 && col.GetComponent<醫療椅>().是否有實驗輪椅在上面 == true && col.GetComponent<醫療椅>().繃帶處理完成 == true)
        {
            if (!撿.isPlaying)
            {
                撿.Play();
            }
            武器.SetActive(false);
            Invoke("D0", 0.1f);
            是否拿起支解實驗輪椅 = true;
            col.GetComponent<醫療椅>().是否有實驗輪椅在上面 = false;
            col.GetComponent<醫療椅>().是否有怪物在上面 = false;
            var EMHP = col.GetComponent<醫療椅>();
            EMHP.消失實驗輪椅();
            手上的支解實驗輪椅.SetActive(true);
        }
        //////////////////////////////////////
        if (col.tag == "福馬林" && Input.GetKey(KeyCode.RightShift) && 是否拿起支解實驗體1 == true)
        {
            武器.SetActive(true);
            Invoke("D1", 0.1f);
            是否拿起支解實驗體1 = false;
            var EMHP = col.GetComponent<福馬林>();
            EMHP.丟實驗體();
            手上的支解實驗體1.SetActive(false);
        }
        if (col.tag == "福馬林" && Input.GetKey(KeyCode.RightShift) && 是否拿起支解實驗熊 == true)
        {
            武器.SetActive(true);
            Invoke("D1", 0.1f);
            是否拿起支解實驗熊 = false;
            var EMHP = col.GetComponent<福馬林>();
            EMHP.丟實驗熊();
            手上的支解實驗熊.SetActive(false);
        }
        if (col.tag == "福馬林" && Input.GetKey(KeyCode.RightShift) && 是否拿起支解實驗輪椅 == true)
        {
            武器.SetActive(true);
            Invoke("D1", 0.1f);
            是否拿起支解實驗輪椅 = false;
            var EMHP = col.GetComponent<福馬林>();
            EMHP.丟實驗輪椅();
            手上的支解實驗輪椅.SetActive(false);
        }
    }

    void 丟東西()
    {
        if (Input.GetKeyDown(KeyCode.RightShift) && 拾取計數器 == 0 && 是否拿起針 == true)
        {
            if (!丟.isPlaying)
            {
                丟.Play();
            }
            武器.SetActive(true);
            是否拿起針 = false;
            手上的針.SetActive(false);
            Invoke("D1", 0.1f);
            GameObject DD = Instantiate(針, 放下位置.transform.position, 放下位置.transform.rotation);
            Rigidbody rig = DD.GetComponent<Rigidbody>();

            rig.AddForce(放下位置.transform.forward * Speed, ForceMode.Impulse);
        }
        if (Input.GetKeyDown(KeyCode.RightShift) && 拾取計數器 == 0 && 是否拿起繃帶 == true)
        {
            if (!丟.isPlaying)
            {
                丟.Play();
            }
            武器.SetActive(true);
            是否拿起繃帶 = false;
            手上的繃帶.SetActive(false);
            Invoke("D1", 0.1f);
            GameObject DD = Instantiate(繃帶, 放下位置.transform.position, 放下位置.transform.rotation);
            Rigidbody rig = DD.GetComponent<Rigidbody>();

            rig.AddForce(放下位置.transform.forward * Speed, ForceMode.Impulse);
        }
        if (Input.GetKeyDown(KeyCode.RightShift) && 拾取計數器 == 0 && 是否拿起AED == true)
        {
            if (!丟.isPlaying)
            {
                丟.Play();
            }
            武器.SetActive(true);
            是否拿起AED = false;
            手上的AED.SetActive(false);
            Invoke("D1", 0.1f);
            GameObject DD = Instantiate(AED, 放下位置.transform.position, 放下位置.transform.rotation);
            Rigidbody rig = DD.GetComponent<Rigidbody>();

            rig.AddForce(放下位置.transform.forward * Speed, ForceMode.Impulse);
        }
        if (Input.GetKeyDown(KeyCode.RightShift) && 拾取計數器 == 0 && 是否拿起鋸子 == true)
        {
            if (!丟.isPlaying)
            {
                丟.Play();
            }
            武器.SetActive(true);
            是否拿起鋸子 = false;
            手上的鋸子.SetActive(false);
            Invoke("D1", 0.1f);
            GameObject DD = Instantiate(鋸子, 放下位置.transform.position, 放下位置.transform.rotation);
            Rigidbody rig = DD.GetComponent<Rigidbody>();

            rig.AddForce(放下位置.transform.forward * Speed, ForceMode.Impulse);
        }
    }
    void D1()
    {
        拾取計數器 = 1;
    }
    void D0()
    {
        拾取計數器 = 0;
    }
    private void OnTriggerExit(Collider col)
    {
        var 發光程式 = col.GetComponent<發光程式>();
        if (發光程式 != null)
        {
            發光程式.沒發光();
        }
    }
}
