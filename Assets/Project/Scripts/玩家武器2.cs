using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 玩家武器2 : MonoBehaviour
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

        if (col.tag == "EM")
        {

            var EMHP = col.GetComponent<敵人控制>();
            if (EMHP != null)
                EMHP.扣血2();
        }
        if (col.tag == "幽靈")
        {

            var EMHP = col.GetComponent<敵人控制>();
            if (EMHP != null)
                EMHP.扣血2();
        }


    }
}
