using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 玩家武器 : MonoBehaviour
{
    public bool 是否為遠程武器;
    // Start is called before the first frame update
    void Start()
    {
        if (是否為遠程武器 == true)
            Destroy(this.gameObject, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider col)
    {

        if (col.tag == "EM" )
        {
     
            var EMHP = col.GetComponent<敵人控制>();
            if (EMHP != null)
                EMHP.扣血();
        }
        if (col.tag == "幽靈")
        {
         
            var EMHP = col.GetComponent<敵人控制>();
            if (EMHP != null)
                EMHP.扣血();
        }
        if (col.tag == "EM"&& 是否為遠程武器 == true)
        {
            Destroy(this.gameObject);
            var EMHP = col.GetComponent<敵人控制>();
            if (EMHP != null)
                EMHP.扣血();
        }
        if (col.tag == "幽靈"&& 是否為遠程武器 == true)
        {
            Destroy(this.gameObject);
            var EMHP = col.GetComponent<敵人控制>();
            if (EMHP != null)
                EMHP.扣血();
        }
    }
}
