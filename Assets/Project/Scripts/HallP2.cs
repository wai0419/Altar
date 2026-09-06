using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HallP2 : MonoBehaviour
{
    //鍵盤控制P2
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



        


        //移動
        inputVector = new Vector3(Input.GetAxis("HorizontalWASD") * Speed, playerBody.linearVelocity.y, Input.GetAxis("VerticalWASD") * -Speed);
        transform.LookAt(transform.position + new Vector3(inputVector.x, 0, inputVector.z));

        if (Input.GetAxis("HorizontalWASD") != 0 || Input.GetAxis("VerticalWASD") != 0)
        {
            動畫控制器.SetBool("走路", true);

            SaveData.P1開始調藥水 = false;
        }
        if (Input.GetAxis("HorizontalWASD") == 0 && Input.GetAxis("VerticalWASD") == 0)
        {
            動畫控制器.SetBool("走路", false);
        }
        if (Input.GetKeyDown(KeyCode.LeftShift) && 是否拿起第一關書 == true && 拾取計數器 == 0)
        {

            Invoke("D1", 0.1f);

            GameObject DD = Instantiate(第一關書, Instantiate_Position2.transform.position, Instantiate_Position2.transform.rotation);
            Rigidbody rig = DD.GetComponent<Rigidbody>();

            rig.AddForce(Instantiate_Position2.transform.forward * Speed, ForceMode.Impulse);

            是否拿起第一關書 = false;
            手上第一關書.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.LeftShift) && 是否拿起第二關書 == true && 拾取計數器 == 0)
        {

            Invoke("D1", 0.1f);

            GameObject DD = Instantiate(第二關書, Instantiate_Position2.transform.position, Instantiate_Position2.transform.rotation);
            Rigidbody rig = DD.GetComponent<Rigidbody>();

            rig.AddForce(Instantiate_Position2.transform.forward * Speed, ForceMode.Impulse);

            是否拿起第二關書 = false;
            手上第二關書.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.LeftShift) && 是否拿起第三關書 == true && 拾取計數器 == 0)
        {

            Invoke("D1", 0.1f);

            GameObject DD = Instantiate(第三關書, Instantiate_Position2.transform.position, Instantiate_Position2.transform.rotation);
            Rigidbody rig = DD.GetComponent<Rigidbody>();

            rig.AddForce(Instantiate_Position2.transform.forward * Speed, ForceMode.Impulse);

            是否拿起第三關書 = false;
            手上第三關書.SetActive(false);
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
    // Start is called before the first frame update

    // Update is called once per frame

    private void OnTriggerStay(Collider col)
    {
        if (col.tag == "第一關書" && Input.GetKey(KeyCode.LeftShift) && 拾取計數器 == 1)
        {
            Invoke("D0", 0.1f);
            是否拿起第一關書 = true;
            手上第一關書.SetActive(true);
            Destroy(col.gameObject);
        }
        if (col.tag == "第二關書" && Input.GetKey(KeyCode.LeftShift) && 拾取計數器 == 1)
        {
            Invoke("D0", 0.1f);
            是否拿起第二關書 = true;
            手上第二關書.SetActive(true);
            Destroy(col.gameObject);
        }
        if (col.tag == "第三關書" && Input.GetKey(KeyCode.LeftShift) && 拾取計數器 == 1)
        {
            Invoke("D0", 0.1f);
            是否拿起第三關書 = true;
            手上第三關書.SetActive(true);
            Destroy(col.gameObject);
        }

        if (col.tag == "講台" && Input.GetKey(KeyCode.LeftControl) && 拾取計數器 == 0 && 是否拿起第一關書 == true && 第二關書放在講台上 != true && 第三關書放在講台上 != true)
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
        if (col.tag == "講台" && Input.GetKey(KeyCode.LeftControl) && 拾取計數器 == 0 && 是否拿起第二關書 == true && 第三關書放在講台上 != true && 第一關書放在講台上 != true)
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
        if (col.tag == "講台" && Input.GetKey(KeyCode.LeftControl) && 拾取計數器 == 0 && 是否拿起第三關書 == true && 第一關書放在講台上 != true && 第二關書放在講台上 != true)
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

        if (col.tag == "講台" && Input.GetKey(KeyCode.LeftShift) && 拾取計數器 == 1 && 第一關書放在講台上 == true)
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
        if (col.tag == "講台" && Input.GetKey(KeyCode.LeftShift) && 拾取計數器 == 1 && 第二關書放在講台上 == true)
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
        if (col.tag == "講台" && Input.GetKey(KeyCode.LeftShift) && 拾取計數器 == 1 && 第三關書放在講台上 == true)
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
        if (col.tag == "NPC")
        {
            var NPC控制 = col.GetComponent<NPC控制>();
            if (NPC控制 != null)
            {
                NPC控制.顯示提示();
            }
            if(Input.GetKey(KeyCode.R))
            {
                NPC控制.開啟對話();
            }
        }
    }
    private void OnTriggerExit(Collider col)
    {
        var NPC控制 = col.GetComponent<NPC控制>();
        if (NPC控制 != null)
        {
            NPC控制.提示消失();
        }
    }
}

