using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HallGo : MonoBehaviour
{
    public int 第幾關;


    public GameObject 跳轉縮小;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerStay(Collider col)
    {
        if (col.tag == "Player" || col.tag == "P2" )
        {


            跳轉縮小.SetActive(true);
            //Debug.Log("111111111111111");
            Invoke("跳1", 2f);
        }

    }

    void 跳1()
    {

            SceneManager.LoadScene(第幾關);
        
       
    }

}
