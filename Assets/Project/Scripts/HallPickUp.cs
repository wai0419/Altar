using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HallPickUp : MonoBehaviour
{
    public GameObject Instantiate_Position; //物件的生成點。

    public GameObject Instantiate_Position2; //物件的生成點。

    public int 拾取計數器 = 1;
    public bool 是否拿起第一關書;
    public bool 是否拿起第二關書;
    public bool 是否拿起第三關書;

    public GameObject 第一關書;
    public GameObject 第二關書;
    public GameObject 第三關書;

    public float speed = 5;
    void D1()
    {
        拾取計數器 = 1;
    }
    void D0()
    {
        拾取計數器 = 0;
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift) && 是否拿起第一關書 == true && 拾取計數器 == 0)
        {
            Invoke("D1", 0.1f);

            GameObject DD = Instantiate(第一關書, Instantiate_Position2.transform.position, Instantiate_Position2.transform.rotation);
            Rigidbody rig = DD.GetComponent<Rigidbody>();

            rig.AddForce(Instantiate_Position2.transform.forward * speed, ForceMode.Impulse);


            是否拿起第一關書 = false;
            第一關書.SetActive(false);
        }
    }
    private void OnTriggerStay(Collider col)
    {


        if (col.tag == "大蒜箱子" && Input.GetKey(KeyCode.LeftShift) &&拾取計數器 == 1)
        {
            Invoke("D0", 0.1f);


        }
        if (col.tag == "大蒜" && Input.GetKey(KeyCode.LeftShift) && 拾取計數器 == 1)
        {

            Invoke("D0", 0.1f);
            是否拿起第一關書 = true;
            第一關書.SetActive(true);
            
            Destroy(col.gameObject);

        }
    }
}
    
