using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class 手把控制1 : MonoBehaviour
{
    public int currentHp = 100;

    public float Speed = 2f;

    Animator 動畫控制器;

    public GameObject 手上的人;

    public GameObject 手上石化吸血鬼;

    public GameObject 手上大蒜;

    public GameObject 手上水杯;

    public GameObject 手上鹽巴;

    public GameObject 手上滿水;

    public GameObject 手上大蒜藥水;

    public GameObject 手上鹽巴藥水;

    public GameObject 手上幽靈;

    public GameObject 手上石化幽靈;

    public GameObject 武器;

    public bool 是否拿起敵人;

    public bool 是否拿起石化吸血鬼;

    public bool 是否拿起幽靈;

    public bool 是否拿起石化幽靈;

    public bool 是否拿起大蒜;

    public bool 是否拿起水杯;

    public bool 是否拿起鹽巴;

    public bool 是否拿起滿水;

    public bool 是否拿起大蒜藥水;

    public bool 是否拿起鹽巴藥水;

    public GameObject 放下位置;

    public GameObject 敵人放下位置;

    public GameObject 敵人;

    public GameObject 大蒜;

    public GameObject 水杯;

    public GameObject 鹽巴;

    public GameObject 滿水;

    public GameObject 石化吸血鬼;

    public GameObject 大蒜藥水;

    public GameObject 鹽巴藥水;

    public GameObject 幽靈;

    public GameObject 石化幽靈;

    public bool 開始調藥水;

    public int 拾取計數器 = 1;

    public float speed = 5;

    [SerializeField]

    private Rigidbody playerBody;

    private Vector3 inputVector;

    public ParticleSystem 受傷;

    public ParticleSystem 完成特效;

    public AudioSource 走路聲;

    public AudioSource 攻擊聲;

    public AudioSource 撿;

    public AudioSource 丟;

    public AudioSource 成功聲;

    public AudioSource 淨化聲;
    public void 扣血特效()
    {
        受傷.Play();
    }
    void Start()
    {
        撿.volume = 0.1f;

        丟.volume = 0.1f;

        淨化聲.volume = 0.5f;

        受傷.Stop();

        完成特效.Stop();

        動畫控制器 = GetComponent<Animator>();

        playerBody = GetComponent<Rigidbody>();

    }

    void Update()
    {

        //攻擊
        if (Input.GetKeyDown(KeyCode.K) && 是否拿起敵人 == false && 是否拿起大蒜 == false)
        {
            if (!攻擊聲.isPlaying)
            {
                攻擊聲.Play();
            }
            動畫控制器.SetBool("攻擊", true);
        }



        if (動畫控制器.GetCurrentAnimatorStateInfo(0).IsName("攻擊"))
        {
            動畫控制器.SetBool("攻擊", false);
            SaveData.P2攻擊中 = true;
            speed = 0;
        }
        if (!動畫控制器.GetCurrentAnimatorStateInfo(0).IsName("攻擊"))
        {

            SaveData.P2攻擊中 = false;
            speed = 5;
        }
        //移動
       

        inputVector = new Vector3(Gamepad.all[0].leftStick.x.ReadValue() * Speed, playerBody.linearVelocity.y, Gamepad.all[0].leftStick.y.ReadValue() * Speed);
        transform.LookAt(transform.position + new Vector3(inputVector.x, 0, inputVector.z));

        if (Gamepad.all[0].leftStick.x.ReadValue() != 0 || Gamepad.all[0].leftStick.y.ReadValue() != 0f)
        {
            if (!走路聲.isPlaying)
            {
                走路聲.Play();
            }
            動畫控制器.SetBool("走路", true);
            開始調藥水 = false;
            SaveData.P2開始調藥水 = false;
        }
        if (Gamepad.all[0].leftStick.x.ReadValue() == 0 && Gamepad.all[0].leftStick.y.ReadValue() == 0f)
        {
            動畫控制器.SetBool("走路", false);
        }


        if (SaveData.P2開始裝滿水 == true)
        {
            武器.SetActive(false);
            手上滿水.SetActive(true);
            是否拿起滿水 = true;

            是否拿起水杯 = false;
            手上水杯.SetActive(false);
            SaveData.P2開始裝滿水 = false;
        }


        if (Input.GetKeyDown(KeyCode.RightShift) && 是否拿起敵人 == true && 拾取計數器 == 0)
        {
            if (!丟.isPlaying)
            {
                丟.Play();
            }
            Invoke("D1", 0.1f);

            GameObject DD = Instantiate(敵人, 敵人放下位置.transform.position, 敵人放下位置.transform.rotation);
            Rigidbody rig = DD.GetComponent<Rigidbody>();

            rig.AddForce(敵人放下位置.transform.forward * speed, ForceMode.Impulse);

            武器.SetActive(true);
            是否拿起敵人 = false;
            手上的人.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.RightShift) && 是否拿起幽靈 == true && 拾取計數器 == 0)
        {
            if (!丟.isPlaying)
            {
                丟.Play();
            }
            Invoke("D1", 0.1f);

            GameObject DD = Instantiate(幽靈, 敵人放下位置.transform.position, 敵人放下位置.transform.rotation);
            Rigidbody rig = DD.GetComponent<Rigidbody>();

            rig.AddForce(敵人放下位置.transform.forward * speed, ForceMode.Impulse);

            武器.SetActive(true);
            是否拿起幽靈 = false;
            手上幽靈.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.RightShift) && 是否拿起大蒜 == true && 拾取計數器 == 0)
        {
            if (!丟.isPlaying)
            {
                丟.Play();
            }
            Invoke("D1", 0.1f);

            GameObject DD = Instantiate(大蒜, 放下位置.transform.position, 放下位置.transform.rotation);
            Rigidbody rig = DD.GetComponent<Rigidbody>();

            rig.AddForce(放下位置.transform.forward * speed, ForceMode.Impulse);

            武器.SetActive(true);
            是否拿起大蒜 = false;
            手上大蒜.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.RightShift) && 是否拿起水杯 == true && 拾取計數器 == 0)
        {
            if (!丟.isPlaying)
            {
                丟.Play();
            }
            Invoke("D1", 0.1f);

            GameObject DD = Instantiate(水杯, 放下位置.transform.position, 放下位置.transform.rotation);
            Rigidbody rig = DD.GetComponent<Rigidbody>();

            rig.AddForce(放下位置.transform.forward * speed, ForceMode.Impulse);
            武器.SetActive(true);
            是否拿起水杯 = false;
            手上水杯.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.RightShift) && 是否拿起鹽巴 == true && 拾取計數器 == 0)
        {
            if (!丟.isPlaying)
            {
                丟.Play();
            }
            Invoke("D1", 0.1f);

            GameObject DD = Instantiate(鹽巴, 放下位置.transform.position, 放下位置.transform.rotation);
            Rigidbody rig = DD.GetComponent<Rigidbody>();

            rig.AddForce(放下位置.transform.forward * speed, ForceMode.Impulse);

            武器.SetActive(true);
            是否拿起鹽巴 = false;
            手上鹽巴.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.RightShift) && 是否拿起滿水 == true && 拾取計數器 == 0)
        {
            if (!丟.isPlaying)
            {
                丟.Play();
            }
            Invoke("D1", 0.1f);

            GameObject DD = Instantiate(滿水, 放下位置.transform.position, 放下位置.transform.rotation);
            Rigidbody rig = DD.GetComponent<Rigidbody>();

            rig.AddForce(放下位置.transform.forward * speed, ForceMode.Impulse);

            武器.SetActive(true);
            是否拿起滿水 = false;
            手上滿水.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.RightShift) && 是否拿起大蒜藥水 == true && 拾取計數器 == 0)
        {
            if (!丟.isPlaying)
            {
                丟.Play();
            }
            Invoke("D1", 0.1f);

            GameObject DD = Instantiate(大蒜藥水, 放下位置.transform.position, 放下位置.transform.rotation);
            Rigidbody rig = DD.GetComponent<Rigidbody>();

            rig.AddForce(放下位置.transform.forward * speed, ForceMode.Impulse);

            武器.SetActive(true);
            是否拿起大蒜藥水 = false;
            手上大蒜藥水.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.RightShift) && 是否拿起鹽巴藥水 == true && 拾取計數器 == 0)
        {
            if (!丟.isPlaying)
            {
                丟.Play();
            }
            Invoke("D1", 0.1f);

            GameObject DD = Instantiate(鹽巴藥水, 放下位置.transform.position, 放下位置.transform.rotation);
            Rigidbody rig = DD.GetComponent<Rigidbody>();

            rig.AddForce(放下位置.transform.forward * speed, ForceMode.Impulse);

            武器.SetActive(true);
            是否拿起鹽巴藥水 = false;
            手上鹽巴藥水.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.RightShift) && 是否拿起石化吸血鬼 == true && 拾取計數器 == 0)
        {
            if (!丟.isPlaying)
            {
                丟.Play();
            }
            Invoke("D1", 0.1f);

            GameObject DD = Instantiate(石化吸血鬼, 放下位置.transform.position, 放下位置.transform.rotation);
            Rigidbody rig = DD.GetComponent<Rigidbody>();

            //rig.AddForce(放下位置.transform.forward * speed, ForceMode.Impulse);

            武器.SetActive(true);
            是否拿起石化吸血鬼 = false;
            手上石化吸血鬼.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.LeftShift) && 是否拿起石化幽靈 == true && 拾取計數器 == 0)
        {
            if (!丟.isPlaying)
            {
                丟.Play();
            }
            Invoke("D1", 0.1f);

            GameObject DD = Instantiate(石化幽靈, 放下位置.transform.position, 放下位置.transform.rotation);
            Rigidbody rig = DD.GetComponent<Rigidbody>();

            //rig.AddForce(放下位置.transform.forward * speed, ForceMode.Impulse);

            武器.SetActive(true);
            是否拿起石化幽靈 = false;
            手上石化幽靈.SetActive(false);
        }
    }
    private void FixedUpdate()
    {
        playerBody.linearVelocity = inputVector;
    }


    void D1()
    {
        拾取計數器 = 1;
    }
    void D0()
    {
        拾取計數器 = 0;
    }
    private void OnTriggerEnter(Collider col)
    {
        if (col.tag == "EM" && Input.GetKey(KeyCode.RightShift) && col.GetComponent<敵人控制>().死亡 == true && 是否拿起大蒜 == false && 是否拿起鹽巴 == false && 是否拿起水杯 == false & 拾取計數器 == 1 && 是否拿起滿水 == false)
        {
            if (!撿.isPlaying)
            {
                撿.Play();
            }
            完成特效.Play();
            var EMHP = col.GetComponent<敵人控制>();
            Invoke("D0", 0.1f);
            if (EMHP != null)
            {
                EMHP.拿起腳色();
                武器.SetActive(false);
                是否拿起敵人 = true;
                手上的人.SetActive(true);
            }
        }
        if (col.tag == "幽靈" && Input.GetKey(KeyCode.RightShift) && col.GetComponent<敵人控制>().死亡 == true && 是否拿起大蒜 == false && 是否拿起鹽巴 == false && 是否拿起水杯 == false & 拾取計數器 == 1 && 是否拿起滿水 == false)
        {
            if (!撿.isPlaying)
            {
                撿.Play();
            }
            完成特效.Play();
            var EMHP = col.GetComponent<敵人控制>();
            Invoke("D0", 0.1f);
            if (EMHP != null)
            {
                EMHP.拿起腳色();
                武器.SetActive(false);
                是否拿起幽靈 = true;
                手上幽靈.SetActive(true);
            }
        }
    }

    private void OnTriggerStay(Collider col)
    {
        //敵人
        if (col.tag == "EM" && Input.GetKey(KeyCode.RightShift) && col.GetComponent<敵人控制>().死亡 == true && 拾取計數器 == 1)
        {
            if (!撿.isPlaying)
            {
                撿.Play();
            }
            完成特效.Play();
            var EMHP = col.GetComponent<敵人控制>();
            Invoke("D0", 0.1f);
            if (EMHP != null)
            {
                EMHP.拿起腳色();
                武器.SetActive(false);
                是否拿起敵人 = true;
                手上的人.SetActive(true);
            }
        }

        if (col.tag == "石化吸血鬼" && Input.GetKey(KeyCode.RightShift) && 是否拿起石化吸血鬼 == false && 拾取計數器 == 1)
        {
            if (!撿.isPlaying)
            {
                撿.Play();
            }
            完成特效.Play();
            Invoke("D0", 0.1f);
            是否拿起石化吸血鬼 = true;
            手上石化吸血鬼.SetActive(true);
            武器.SetActive(false);
            Destroy(col.gameObject);

        }

        if (col.tag == "幽靈" && Input.GetKey(KeyCode.RightShift) && col.GetComponent<敵人控制>().死亡 == true && 拾取計數器 == 1)
        {
            if (!撿.isPlaying)
            {
                撿.Play();
            }
            完成特效.Play();
            var EMHP = col.GetComponent<敵人控制>();
            Invoke("D0", 0.1f);
            if (EMHP != null)
            {
                EMHP.拿起腳色();
                武器.SetActive(false);
                是否拿起幽靈 = true;
                手上幽靈.SetActive(true);
            }
        }

        if (col.tag == "石化幽靈" && Input.GetKey(KeyCode.RightShift) && 是否拿起石化幽靈 == false && 拾取計數器 == 1)
        {
            if (!撿.isPlaying)
            {
                撿.Play();
            }
            完成特效.Play();
            Invoke("D0", 0.1f);
            是否拿起石化幽靈 = true;
            手上石化幽靈.SetActive(true);
            武器.SetActive(false);
            Destroy(col.gameObject);

        }
        //大蒜
        if (col.tag == "大蒜箱子" && Input.GetKey(KeyCode.RightShift) && 是否拿起敵人 == false && 拾取計數器 == 1)
        {
            if (!撿.isPlaying)
            {
                撿.Play();
            }
            完成特效.Play();
            Invoke("D0", 0.1f);
            是否拿起大蒜 = true;
            手上大蒜.SetActive(true);
            武器.SetActive(false);

        }

        if (col.tag == "大蒜" && Input.GetKey(KeyCode.RightShift) && 是否拿起敵人 == false && 拾取計數器 == 1)
        {
            if (!撿.isPlaying)
            {
                撿.Play();
            }
            完成特效.Play();
            Invoke("D0", 0.1f);
            是否拿起大蒜 = true;
            手上大蒜.SetActive(true);
            武器.SetActive(false);
            Destroy(col.gameObject);

        }



        //水杯
        if (col.tag == "藥水箱子" && Input.GetKey(KeyCode.RightShift) && 是否拿起敵人 == false && 拾取計數器 == 1)
        {
            if (!撿.isPlaying)
            {
                撿.Play();
            }
            完成特效.Play();
            Invoke("D0", 0.1f);
            是否拿起水杯 = true;
            手上水杯.SetActive(true);
            武器.SetActive(false);

        }

        if (col.tag == "藥水" && Input.GetKey(KeyCode.RightShift) && 是否拿起敵人 == false && 拾取計數器 == 1)
        {
            if (!撿.isPlaying)
            {
                撿.Play();
            }
            完成特效.Play();
            Invoke("D0", 0.1f);
            是否拿起水杯 = true;
            手上水杯.SetActive(true);
            武器.SetActive(false);
            Destroy(col.gameObject);

        }

        if (col.tag == "滿水" && Input.GetKey(KeyCode.RightShift) && 是否拿起敵人 == false && 拾取計數器 == 1)
        {
            if (!撿.isPlaying)
            {
                撿.Play();
            }
            完成特效.Play();
            Invoke("D0", 0.1f);
            武器.SetActive(false);
            手上滿水.SetActive(true);
            是否拿起滿水 = true;
            Destroy(col.gameObject);
        }

        //鹽巴
        if (col.tag == "鹽巴箱子" && Input.GetKey(KeyCode.RightShift) && 是否拿起敵人 == false && 拾取計數器 == 1)
        {
            if (!撿.isPlaying)
            {
                撿.Play();
            }
            完成特效.Play();
            Invoke("D0", 0.1f);
            是否拿起鹽巴 = true;
            手上鹽巴.SetActive(true);
            武器.SetActive(false);

        }

        if (col.tag == "鹽巴" && Input.GetKey(KeyCode.RightShift) && 是否拿起敵人 == false && 拾取計數器 == 1)
        {
            if (!撿.isPlaying)
            {
                撿.Play();
            }
            完成特效.Play();
            Invoke("D0", 0.1f);
            是否拿起鹽巴 = true;
            手上鹽巴.SetActive(true);
            武器.SetActive(false);
            Destroy(col.gameObject);
        }


        if (col.tag == "鹽巴藥水" && Input.GetKey(KeyCode.RightShift) && 是否拿起敵人 == false && 拾取計數器 == 1)
        {
            if (!撿.isPlaying)
            {
                撿.Play();
            }
            完成特效.Play();
            Invoke("D0", 0.1f);
            武器.SetActive(false);
            是否拿起鹽巴藥水 = true;
            手上鹽巴藥水.SetActive(true);
            Destroy(col.gameObject);
        }

        if (col.tag == "大蒜藥水" && Input.GetKey(KeyCode.RightShift) && 是否拿起敵人 == false && 拾取計數器 == 1)
        {
            if (!撿.isPlaying)
            {
                撿.Play();
            }
            完成特效.Play();
            Invoke("D0", 0.1f);
            武器.SetActive(false);
            是否拿起大蒜藥水 = true;
            手上大蒜藥水.SetActive(true);
            Destroy(col.gameObject);
        }




        //祭壇
        if (col.tag == "祭壇" && Input.GetKey(KeyCode.RightControl) && col.GetComponent<祭壇>().顯示吸血鬼 == false && 是否拿起敵人 == true && 拾取計數器 == 0)
        {
            if (!丟.isPlaying)
            {
                丟.Play();
            }
            var EMHP = col.GetComponent<祭壇>();
            Invoke("D1", 0.1f);

            EMHP.放敵人();
            武器.SetActive(true);
            是否拿起敵人 = false;
            手上的人.SetActive(false);

        }

        if (col.tag == "祭壇" && Input.GetKey(KeyCode.RightControl) && col.GetComponent<祭壇>().顯示幽靈 == false && 是否拿起幽靈 == true && 拾取計數器 == 0)
        {
            if (!丟.isPlaying)
            {
                丟.Play();
            }
            var EMHP = col.GetComponent<祭壇>();
            Invoke("D1", 0.1f);

            EMHP.放幽靈();
            武器.SetActive(true);
            是否拿起幽靈 = false;
            手上幽靈.SetActive(false);

        }



        if (col.tag == "祭壇" && Input.GetKey(KeyCode.RightShift) && col.GetComponent<祭壇>().顯示吸血鬼 == true && 拾取計數器 == 1)
        {
            if (!撿.isPlaying)
            {
                撿.Play();
            }
            var EMHP = col.GetComponent<祭壇>();
            Invoke("D0", 0.1f);

            EMHP.拿敵人();
            武器.SetActive(false);
            是否拿起敵人 = true;
            手上的人.SetActive(true);

        }

        if (col.tag == "祭壇" && Input.GetKey(KeyCode.RightShift) && col.GetComponent<祭壇>().顯示石化吸血鬼 == true && 拾取計數器 == 1)
        {
            if (!撿.isPlaying)
            {
                撿.Play();
            }
            var EMHP = col.GetComponent<祭壇>();
            Invoke("D0", 0.1f);

            EMHP.拿石化吸血鬼();
            武器.SetActive(false);
            是否拿起石化吸血鬼 = true;
            手上石化吸血鬼.SetActive(true);

        }

        if (col.tag == "祭壇" && Input.GetKey(KeyCode.RightShift) && col.GetComponent<祭壇>().顯示幽靈 == true && 拾取計數器 == 1)
        {
            if (!撿.isPlaying)
            {
                撿.Play();
            }
            var EMHP = col.GetComponent<祭壇>();
            Invoke("D0", 0.1f);

            EMHP.拿敵人();
            武器.SetActive(false);
            是否拿起幽靈 = true;
            手上幽靈.SetActive(true);

        }

        if (col.tag == "祭壇" && Input.GetKey(KeyCode.RightShift) && col.GetComponent<祭壇>().顯示石化幽靈 == true && 拾取計數器 == 1)
        {
            if (!撿.isPlaying)
            {
                撿.Play();
            }
            var EMHP = col.GetComponent<祭壇>();
            Invoke("D0", 0.1f);

            EMHP.拿石化幽靈();
            武器.SetActive(false);
            是否拿起石化幽靈 = true;
            手上石化幽靈.SetActive(true);

        }

        if (col.tag == "祭壇" && Input.GetKey(KeyCode.RightControl) && col.GetComponent<祭壇>().顯示吸血鬼 == true && 拾取計數器 == 0 && 是否拿起大蒜藥水 == true)
        {
            if (!淨化聲.isPlaying)
            {
                淨化聲.Play();
            }
            var EMHP = col.GetComponent<祭壇>();
            Invoke("D1", 0.1f);
            Invoke("速度調回正常", 3f);
            EMHP.灑藥水效果();
            武器.SetActive(true);
            是否拿起大蒜藥水 = false;
            手上大蒜藥水.SetActive(false);

        }

        if (col.tag == "祭壇" && Input.GetKey(KeyCode.RightControl) && col.GetComponent<祭壇>().顯示幽靈 == true && 拾取計數器 == 0 && 是否拿起鹽巴藥水 == true)
        {
            if (!淨化聲.isPlaying)
            {
                淨化聲.Play();
            }
            var EMHP = col.GetComponent<祭壇>();
            Invoke("D1", 0.1f);
            Invoke("速度調回正常", 3f);
            EMHP.石化幽靈效果();
            武器.SetActive(true);
            是否拿起鹽巴藥水 = false;
            手上鹽巴藥水.SetActive(false);

        }




        //講台
        if (col.tag == "講台" && Input.GetKey(KeyCode.RightControl) && 拾取計數器 == 0 && 是否拿起滿水 == true && col.GetComponent<講台>().是否顯示水 == false)
        {
            if (!丟.isPlaying)
            {
                丟.Play();
            }
            if (col.GetComponent<講台>().是否顯示大蒜 == false && col.GetComponent<講台>().是否顯示鹽巴 == false)
            {
                var EMHP = col.GetComponent<講台>();
                Invoke("D1", 0.1f);

                武器.SetActive(true);
                是否拿起滿水 = false;
                手上滿水.SetActive(false);

                EMHP.顯示水();
            }
            if (col.GetComponent<講台>().是否顯示大蒜 == true)
            {
                var EMHP = col.GetComponent<講台>();
                Invoke("D1", 0.1f);


                武器.SetActive(true);
                是否拿起滿水 = false;
                手上滿水.SetActive(false);

                EMHP.顯示大蒜和水();
            }
            if (col.GetComponent<講台>().是否顯示鹽巴 == true)
            {
                var EMHP = col.GetComponent<講台>();
                Invoke("D1", 0.1f);


                武器.SetActive(true);
                是否拿起滿水 = false;
                手上滿水.SetActive(false);

                EMHP.顯示鹽巴和水();
            }
        }

        if (col.tag == "講台" && Input.GetKey(KeyCode.RightControl) && 拾取計數器 == 0 && 是否拿起大蒜 == true && col.GetComponent<講台>().是否顯示大蒜 == false && col.GetComponent<講台>().是否顯示鹽巴 == false)
        {
            if (!丟.isPlaying)
            {
                丟.Play();
            }
            if (col.GetComponent<講台>().是否顯示水 == false)
            {
                var EMHP = col.GetComponent<講台>();
                Invoke("D1", 0.1f);

                武器.SetActive(true);
                是否拿起大蒜 = false;
                手上大蒜.SetActive(false);

                EMHP.顯示大蒜();
            }
            if (col.GetComponent<講台>().是否顯示水 == true)
            {
                var EMHP = col.GetComponent<講台>();
                Invoke("D1", 0.1f);


                武器.SetActive(true);
                是否拿起大蒜 = false;
                手上大蒜.SetActive(false);

                EMHP.顯示大蒜和水();
            }
        }

        if (col.tag == "講台" && Input.GetKey(KeyCode.RightControl) && 拾取計數器 == 0 && 是否拿起鹽巴 == true && col.GetComponent<講台>().是否顯示鹽巴 == false && col.GetComponent<講台>().是否顯示大蒜 == false)
        {
            if (!丟.isPlaying)
            {
                丟.Play();
            }
            if (col.GetComponent<講台>().是否顯示水 == false)
            {
                var EMHP = col.GetComponent<講台>();
                Invoke("D1", 0.1f);

                武器.SetActive(true);
                是否拿起鹽巴 = false;
                手上鹽巴.SetActive(false);

                EMHP.顯示鹽巴();
            }
            if (col.GetComponent<講台>().是否顯示水 == true)
            {
                var EMHP = col.GetComponent<講台>();
                Invoke("D1", 0.1f);


                武器.SetActive(true);
                是否拿起鹽巴 = false;
                手上鹽巴.SetActive(false);

                EMHP.顯示鹽巴和水();
            }
        }

        if (col.tag == "講台" && Input.GetKey(KeyCode.RightControl) && (col.GetComponent<講台>().是否顯示鹽巴和水 == true || col.GetComponent<講台>().是否顯示大蒜和水 == true) && 拾取計數器 == 1)
        {
            if (col.GetComponent<講台>().開始運作 == true)
            {
                開始調藥水 = true;

                武器.SetActive(true);
                var EMHP = col.GetComponent<講台>();
                if (EMHP != null && 開始調藥水 == true)
                {
                    SaveData.P2開始調藥水 = true;
                    EMHP.P2製作魔藥();

                }
            }
            if (col.GetComponent<講台>().開始運作 == false)
            {
                開始調藥水 = true;

                武器.SetActive(true);
                var EMHP = col.GetComponent<講台>();
                if (EMHP != null && 開始調藥水 == true)
                {
                    SaveData.P2開始調藥水 = true;
                    EMHP.P2製作魔藥();

                }
            }
        }

        if (col.tag == "講台" && Input.GetKey(KeyCode.RightShift) && 拾取計數器 == 1 && (col.GetComponent<講台>().已生成鹽巴藥水 == true || col.GetComponent<講台>().已生成大蒜藥水 == true))
        {
            if (!撿.isPlaying)
            {
                撿.Play();
            }
            Invoke("D0", 0.1f);
            if (col.GetComponent<講台>().已生成鹽巴藥水 == true)
            {
                col.GetComponent<講台>().已生成鹽巴藥水 = false;
                var EMHP = col.GetComponent<講台>();
                if (EMHP != null)
                {

                    EMHP.重新();

                }
                武器.SetActive(false);
                是否拿起鹽巴藥水 = true;
                手上鹽巴藥水.SetActive(true);
            }

            if (col.GetComponent<講台>().已生成大蒜藥水 == true)
            {
                var EMHP = col.GetComponent<講台>();
                if (EMHP != null)
                {

                    EMHP.重新();

                }
                col.GetComponent<講台>().已生成大蒜藥水 = false;
                武器.SetActive(false);
                是否拿起大蒜藥水 = true;
                手上大蒜藥水.SetActive(true);

            }
        }





        if (col.tag == "裝水" && Input.GetKey(KeyCode.RightControl) && 是否拿起水杯 == true)
        {
            if (col.GetComponent<裝水>().開始運作 == true)
            {
                開始調藥水 = true;

                武器.SetActive(true);
                var EMHP = col.GetComponent<裝水>();
                if (EMHP != null && 開始調藥水 == true)
                {
                    SaveData.P2開始調藥水 = true;
                    EMHP.P2正在裝水();

                }
            }
            if (col.GetComponent<裝水>().開始運作 == false)
            {
                開始調藥水 = true;

                武器.SetActive(true);
                var EMHP = col.GetComponent<裝水>();
                if (EMHP != null && 開始調藥水 == true)
                {
                    SaveData.P2開始調藥水 = true;
                    EMHP.P2正在裝水();

                }
            }
        }



        if (col.tag == "焚化爐" && Input.GetKey(KeyCode.RightControl) && 拾取計數器 == 0 && 是否拿起石化吸血鬼 == true)
        {
            完成特效.Play();
            Invoke("D1", 0.1f);
            武器.SetActive(true);
            是否拿起石化吸血鬼 = false;
            手上石化吸血鬼.SetActive(false);
            var EMHP = col.GetComponent<焚化爐>();
            if (EMHP != null)
            {
                SaveData.P1開始調藥水 = true;
                EMHP.特效();

            }
            if (!成功聲.isPlaying)
            {
                成功聲.Play();
            }
        }

        if (col.tag == "焚化爐" && Input.GetKey(KeyCode.RightControl) && 拾取計數器 == 0 && 是否拿起石化幽靈 == true)
        {
            完成特效.Play();
            Invoke("D1", 0.1f);
            武器.SetActive(true);
            是否拿起石化幽靈 = false;
            手上石化幽靈.SetActive(false);
            var EMHP = col.GetComponent<焚化爐>();
            if (EMHP != null)
            {

                EMHP.幽靈特效();

            }
            if (!成功聲.isPlaying)
            {
                成功聲.Play();
            }
        }
    }
    void 速度調回正常()
    {
        Speed = 3.5f;
    }
}
