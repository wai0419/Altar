using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 第三關右P2 : MonoBehaviour
{
    //地圖一左鍵盤P2槍模式

    public float Speed = 4f;

    Animator 動畫控制器;

    public GameObject 武器;

    public GameObject 放下位置;

    public GameObject 敵人放下位置;

    public bool 是否拿起鏟子;

    public GameObject 手上鏟子;

    public GameObject 鏟子總成;

    public int 拾取計數器 = 1;

    [SerializeField]

    private Rigidbody playerBody;

    private Vector3 inputVector;

    public ParticleSystem 受傷;

    public ParticleSystem 完成特效;



    public Rigidbody 子彈;

    public GameObject 手上肌肉殭屍;

    public GameObject 手上一般殭屍;

    public bool 是否拿起肌肉殭屍;

    public bool 是否拿起一般殭屍;
    public GameObject 書本總成;

    public bool 是否拿起書本;

    public GameObject 手上書本;
    public AudioSource 走路聲;

    public AudioSource 攻擊聲;

    public AudioSource 撿;

    public AudioSource 丟;
    public void 扣血特效()
    {
        受傷.Play();
    }
    void Start()
    {

        受傷.Stop();

        完成特效.Stop();

        動畫控制器 = GetComponent<Animator>();

        playerBody = GetComponent<Rigidbody>();

    }

    void Update()
    {
        丟東西();

        //攻擊
        if (Input.GetKeyDown(KeyCode.RightControl) && 是否拿起書本 == false && 是否拿起鏟子 == false && 是否拿起肌肉殭屍 == false && 是否拿起一般殭屍 == false)
        {
            if (!攻擊聲.isPlaying)
            {
                攻擊聲.Play();
            }
            Rigidbody clone;
            clone = Instantiate(子彈, 放下位置.transform.position, 放下位置.transform.rotation) as Rigidbody;
            clone.linearVelocity = transform.TransformDirection(Vector3.forward * 10);
            動畫控制器.SetBool("攻擊", true);

        }



        if (動畫控制器.GetCurrentAnimatorStateInfo(0).IsName("攻擊"))
        {
            動畫控制器.SetBool("攻擊", false);
            第三關儲存空間.P2攻擊中 = true;
            Speed = 0;


        }
        if (!動畫控制器.GetCurrentAnimatorStateInfo(0).IsName("攻擊"))
        {
            第三關儲存空間.P2攻擊中 = false;
            Speed = 3.5f;
        }
        //移動
        inputVector = new Vector3(Input.GetAxis("Horizontal") * Speed, playerBody.linearVelocity.y, Input.GetAxis("Vertical") * Speed);
        transform.LookAt(transform.position + new Vector3(inputVector.x, 0, inputVector.z));

        if (Input.GetAxis("Horizontal") != 0 || Input.GetAxis("Vertical") != 0)
        {
            if (!走路聲.isPlaying)
            {
                走路聲.Play();
            }
            動畫控制器.SetBool("走路", true);
        }
        if (Input.GetAxis("Horizontal") == 0 && Input.GetAxis("Vertical") == 0)
        {
            動畫控制器.SetBool("走路", false);
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
        if (col.tag == "鏟子箱子" && Input.GetKey(KeyCode.RightShift) && 拾取計數器 == 1)
        {
            if (!撿.isPlaying)
            {
                撿.Play();
            }
            武器.SetActive(false);
            Invoke("D0", 0.1f);
            手上鏟子.SetActive(true);
            是否拿起鏟子 = true;
        }
        if (col.tag == "第一關書" && Input.GetKey(KeyCode.RightShift) && 拾取計數器 == 1)
        {
            if (!撿.isPlaying)
            {
                撿.Play();
            }
            武器.SetActive(false);
            Invoke("D0", 0.1f);
            手上書本.SetActive(true);
            是否拿起書本 = true;
            Destroy(col.gameObject.transform.parent.gameObject);
        }
        if (col.tag == "鏟子" && Input.GetKey(KeyCode.RightShift) && 拾取計數器 == 1)
        {
            if (!撿.isPlaying)
            {
                撿.Play();
            }
            武器.SetActive(false);
            Invoke("D0", 0.1f);
            手上鏟子.SetActive(true);
            是否拿起鏟子 = true;
            Destroy(col.gameObject.transform.parent.gameObject);
        }
        if (col.tag == "土" && Input.GetKey(KeyCode.RightControl) && 是否拿起鏟子 == true)
        {
            col.gameObject.SetActive(false);
        }
        if (col.tag == "肌肉殭屍" && Input.GetKey(KeyCode.RightShift) && 拾取計數器 == 1 && col.gameObject.GetComponent<第三關敵人>().死亡 == true)
        {
            if (!撿.isPlaying)
            {
                撿.Play();
            }
            武器.SetActive(false);
            Invoke("D0", 0.1f);
            手上肌肉殭屍.SetActive(true);
            是否拿起肌肉殭屍 = true;
            Destroy(col.gameObject);
        }
        if (col.tag == "一般殭屍" && Input.GetKey(KeyCode.RightShift) && 拾取計數器 == 1 && col.gameObject.GetComponent<第三關敵人>().死亡 == true)
        {
            if (!撿.isPlaying)
            {
                撿.Play();
            }
            武器.SetActive(false);
            Invoke("D0", 0.1f);
            手上一般殭屍.SetActive(true);
            是否拿起一般殭屍 = true;
            Destroy(col.gameObject);
        }
        if (col.tag == "墳墓" && Input.GetKey(KeyCode.RightShift) && 是否拿起肌肉殭屍 == true && col.gameObject.GetComponent<第三關墳墓>().是否有怪物在上面 == false)
        {
            Invoke("D1", 0.1f);
            武器.SetActive(true);
            col.gameObject.GetComponent<第三關墳墓>().是否有怪物在上面 = true;
            col.gameObject.GetComponent<第三關墳墓>().是否有肌肉殭屍在上面 = true;
            手上肌肉殭屍.SetActive(false);
            是否拿起肌肉殭屍 = false;
            var EMHP = col.GetComponent<第三關墳墓>();
            EMHP.顯示肌肉殭屍();
        }
        if (col.tag == "墳墓" && Input.GetKey(KeyCode.RightShift) && 是否拿起一般殭屍 == true && col.gameObject.GetComponent<第三關墳墓>().是否有怪物在上面 == false)
        {
            Invoke("D1", 0.1f);
            武器.SetActive(true);
            col.gameObject.GetComponent<第三關墳墓>().是否有怪物在上面 = true;
            col.gameObject.GetComponent<第三關墳墓>().是否有一般殭屍在上面 = true;
            手上一般殭屍.SetActive(false);
            是否拿起一般殭屍 = false;
            col.gameObject.GetComponent<第三關墳墓>().顯示一般殭屍();

        }

        if (col.tag == "墳墓" && Input.GetKey(KeyCode.RightControl) && 是否拿起鏟子 == true && col.gameObject.GetComponent<第三關墳墓>().是否有肌肉殭屍在上面 == true)
        {
            var EMHP = col.GetComponent<第三關墳墓>();
            EMHP.埋肌肉殭屍();
            col.gameObject.GetComponent<第三關墳墓>().是否可以禱告 = true;

        }
        if (col.tag == "墳墓" && Input.GetKey(KeyCode.RightControl) && 是否拿起鏟子 == true && col.gameObject.GetComponent<第三關墳墓>().是否有一般殭屍在上面 == true)
        {
            var EMHP = col.GetComponent<第三關墳墓>();
            EMHP.埋一般殭屍();
            col.gameObject.GetComponent<第三關墳墓>().是否可以禱告 = true;
        }
        if (col.tag == "墳墓" && Input.GetKey(KeyCode.LeftControl) && 是否拿起書本 == true && col.gameObject.GetComponent<第三關墳墓>().是否可以禱告 == true)
        {
            if (col.gameObject.GetComponent<第三關墳墓>().是否有一般殭屍在上面 == true)
            {

                var EMHP = col.GetComponent<第三關墳墓>();
                EMHP.進度條();
            }
            if (col.gameObject.GetComponent<第三關墳墓>().是否有肌肉殭屍在上面 == true)
            {

                var EMHP = col.GetComponent<第三關墳墓>();
                EMHP.進度條();
            }
        }
        if (col.tag == "講台" && Input.GetKey(KeyCode.RightShift) && 拾取計數器 == 1)
        {
            if (!撿.isPlaying)
            {
                撿.Play();
            }
            武器.SetActive(false);
            Invoke("D0", 0.1f);
            手上書本.SetActive(true);
            是否拿起書本 = true;
        }

    }
    private void OnTriggerExit(Collider col)
    {
        var 發光程式 = col.GetComponent<發光程式>();
        if (發光程式 != null)
        {
            發光程式.沒發光();
        }
    }

    void 丟東西()
    {
        if (Input.GetKeyDown(KeyCode.RightShift) && 拾取計數器 == 0 && 是否拿起鏟子 == true)
        {
            if (!丟.isPlaying)
            {
                丟.Play();
            }
            武器.SetActive(true);
            是否拿起鏟子 = false;
            手上鏟子.SetActive(false);
            Invoke("D1", 0.1f);
            GameObject DD = Instantiate(鏟子總成, 放下位置.transform.position, 放下位置.transform.rotation);
            Rigidbody rig = DD.GetComponent<Rigidbody>();

            rig.AddForce(放下位置.transform.forward * Speed, ForceMode.Impulse);
        }
        if (Input.GetKeyDown(KeyCode.RightShift) && 拾取計數器 == 0 && 是否拿起書本 == true)
        {
            if (!丟.isPlaying)
            {
                丟.Play();
            }
            武器.SetActive(true);
            是否拿起書本 = false;
            手上書本.SetActive(false);
            Invoke("D1", 0.1f);
            GameObject DD = Instantiate(書本總成, 放下位置.transform.position, 放下位置.transform.rotation);
            Rigidbody rig = DD.GetComponent<Rigidbody>();

            rig.AddForce(放下位置.transform.forward * Speed, ForceMode.Impulse);
        }
    }
}
