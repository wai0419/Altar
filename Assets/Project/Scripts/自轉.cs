using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class 自轉 : MonoBehaviour
{
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 30, 0);
    }
    private void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {
            col.GetComponent<玩家血量>().扣血(); ;
        }
        if (col.tag == "P2")
        {
            col.GetComponent<玩家血量>().扣血(); ;
        }

    }
}
