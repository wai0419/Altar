using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 第二關敵人武器 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
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
