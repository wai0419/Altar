using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 陷阱碰撞器 : MonoBehaviour
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
            第二關儲存空間.P1HP -= 0.1f;
        }
        if (col.tag == "P2")
        {
            第二關儲存空間.P2HP -= 0.1f;
        }
    }
}
