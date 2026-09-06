using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class 手把控制P3 : MonoBehaviour
{
    //手把控制P3
    public GameObject Instantiate_Position2; //物件的生成點。

    public int 拾取計數器 = 1;
    public bool 是否拿起第一關書;
    public bool 是否拿起第二關書;
    public bool 是否拿起第三關書;

    public GameObject 第一關書;
    public GameObject 第二關書;
    public GameObject 第三關書;

    public GameObject 手上第一關書;
    public GameObject 手上第二關書;
    public GameObject 手上第三關書;

    public bool 第一關書放在講台上;
    public bool 第二關書放在講台上;
    public bool 第三關書放在講台上;

    public int currentHp = 100;

    public float Speed = 1f;

    Animator 動畫控制器;


    public bool EMT;



    [SerializeField]
    private Rigidbody playerBody;

    private Vector3 inputVector;


    void Start()
    {
        動畫控制器 = GetComponent<Animator>();

        playerBody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            for (int i = 0; i < Gamepad.all.Count; i++)
            {
                Debug.Log(Gamepad.all[i].name);
            }
        }
        if (Mathf.Abs(Gamepad.all[1].leftStick.x.ReadValue()) > 0.3f || Mathf.Abs(Gamepad.all[1].leftStick.y.ReadValue()) > 0.3f)
        {
            動畫控制器.SetBool("走路", true);
            Speed = 3.5f;
            SaveData.P1開始調藥水 = false;

        }

        inputVector = new Vector3(Gamepad.all[1].leftStick.x.ReadValue() * Speed, playerBody.linearVelocity.y, Gamepad.all[1].leftStick.y.ReadValue() * Speed);
        transform.LookAt(transform.position + new Vector3(inputVector.x, 0, inputVector.z));
        //移動

        if (Gamepad.all[1].leftStick.x.ReadValue() == 0 && Gamepad.all[1].leftStick.y.ReadValue() == 0f)
        {
            Speed = 0;
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

        if (col.tag == "第一關書" && Gamepad.all[1].buttonSouth.wasPressedThisFrame && 拾取計數器 == 1)
        {
            Invoke("D0", 0.1f);
            是否拿起第一關書 = true;
            手上第一關書.SetActive(true);
            Destroy(col.gameObject);
        }

        if (col.tag == "第二關書" && Gamepad.all[1].buttonSouth.wasPressedThisFrame && 拾取計數器 == 1)
        {
            Invoke("D0", 0.1f);
            是否拿起第二關書 = true;
            手上第二關書.SetActive(true);
            Destroy(col.gameObject);
        }
        if (col.tag == "第三關書" && Gamepad.all[1].buttonSouth.wasPressedThisFrame && 拾取計數器 == 1)
        {
            Invoke("D0", 0.1f);
            是否拿起第三關書 = true;
            手上第三關書.SetActive(true);
            Destroy(col.gameObject);
        }

        if (col.tag == "講台" && Gamepad.all[1].buttonWest.wasPressedThisFrame && 拾取計數器 == 0 && 是否拿起第一關書 == true && 第二關書放在講台上 != true && 第三關書放在講台上 != true)
        {
            Invoke("D1", 0.1f);
            第一關書放在講台上 = true;
            是否拿起第一關書 = false;
            手上第一關書.SetActive(false);
            var EMHP = col.GetComponent<HallPodium>();
            if (EMHP != null)
            {
                EMHP.顯示第一關();

            }
        }
        if (col.tag == "講台" && Gamepad.all[1].buttonWest.wasPressedThisFrame && 拾取計數器 == 0 && 是否拿起第二關書 == true && 第三關書放在講台上 != true && 第一關書放在講台上 != true)
        {
            Invoke("D1", 0.1f);
            第二關書放在講台上 = true;
            是否拿起第二關書 = false;
            手上第二關書.SetActive(false);
            var EMHP = col.GetComponent<HallPodium>();
            if (EMHP != null)
            {
                EMHP.顯示第二關();

            }
        }
        if (col.tag == "講台" && Gamepad.all[1].buttonWest.wasPressedThisFrame && 拾取計數器 == 0 && 是否拿起第三關書 == true && 第一關書放在講台上 != true && 第二關書放在講台上 != true)
        {
            Invoke("D1", 0.1f);
            第三關書放在講台上 = true;
            是否拿起第三關書 = false;
            手上第三關書.SetActive(false);
            var EMHP = col.GetComponent<HallPodium>();
            if (EMHP != null)
            {
                EMHP.顯示第三關();

            }
        }

        if (col.tag == "講台" && Gamepad.all[1].buttonSouth.wasPressedThisFrame && 拾取計數器 == 1 && 第一關書放在講台上 == true)
        {
            Invoke("D0", 0.1f);
            是否拿起第一關書 = true;
            手上第一關書.SetActive(true);
            第一關書放在講台上 = false;

            var EMHP = col.GetComponent<HallPodium>();
            if (EMHP != null)
            {
                EMHP.消失第一關();

            }
        }
        if (col.tag == "講台" && Gamepad.all[1].buttonSouth.wasPressedThisFrame && 拾取計數器 == 1 && 第二關書放在講台上 == true)
        {
            Invoke("D0", 0.1f);
            是否拿起第二關書 = true;
            手上第二關書.SetActive(true);
            第二關書放在講台上 = false;

            var EMHP = col.GetComponent<HallPodium>();
            if (EMHP != null)
            {
                EMHP.消失第二關();

            }
        }
        if (col.tag == "講台" && Gamepad.all[1].buttonSouth.wasPressedThisFrame && 拾取計數器 == 1 && 第三關書放在講台上 == true)
        {
            Invoke("D0", 0.1f);
            是否拿起第三關書 = true;
            手上第三關書.SetActive(true);
            第三關書放在講台上 = false;

            var EMHP = col.GetComponent<HallPodium>();
            if (EMHP != null)
            {
                EMHP.消失第三關();

            }
        }
    }
}
