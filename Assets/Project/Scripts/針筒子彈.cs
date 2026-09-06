using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 針筒子彈 : MonoBehaviour
{
    public int MS = 10;

    public Vector3 V;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(this.gameObject, 3f);

        transform.rotation = Quaternion.Euler(new Vector3(-90, 0, GameObject.FindWithTag("P2").transform.eulerAngles.y));
        
    }

    private void OnTriggerEnter(Collider col)
    {

        if (col.tag == "實驗體X33")
        {
            Destroy(this.gameObject);
        }

        if (col.tag == "實驗熊")
        {
            Destroy(this.gameObject);
        }

        if (col.tag == "實驗輪椅")
        {
            Destroy(this.gameObject);
        }

    }
}
