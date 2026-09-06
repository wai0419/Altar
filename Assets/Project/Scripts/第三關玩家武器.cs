using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 第三關玩家武器 : MonoBehaviour
{
    public bool 是否為遠程武器;
    // Start is called before the first frame update
    void Start()
    {
        if (是否為遠程武器 == true)
            Destroy(this.gameObject, 1f);
    }

    private void OnTriggerEnter(Collider col)
    {

        if (col.tag == "肌肉殭屍"&& 是否為遠程武器 == true)
        {
            Destroy(this.gameObject);
            var EMHP = col.GetComponent<第三關敵人>();
            if (EMHP != null)
                EMHP.扣血();
        }
        if (col.tag == "一般殭屍" && 是否為遠程武器 == true)
        {
            Destroy(this.gameObject);
            var EMHP = col.GetComponent<第三關敵人>();
            if (EMHP != null)
                EMHP.扣血();
        }
        if (col.tag == "肌肉殭屍"&& 第三關儲存空間.P1攻擊中 == true)
        {
            
            var EMHP = col.GetComponent<第三關敵人>();
            if (EMHP != null)
                EMHP.扣血();
        }
        if (col.tag == "一般殭屍" && 第三關儲存空間.P1攻擊中 == true)
        {
            
            var EMHP = col.GetComponent<第三關敵人>();
            if (EMHP != null)
                EMHP.扣血();
        }
    }
}
