using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 發光程式 : MonoBehaviour
{
    public GameObject 發光物體;

    public GameObject 沒發光物體;
    // Start is called before the first frame update
    void Start()
    {
        
    

        
    }

    // Update is called once per frame
    void Update()
    {
 
    }
    public void 發光()
    {
        發光物體.SetActive(true);
        沒發光物體.SetActive(false);
    }
    public void 沒發光()
    {
        發光物體.SetActive(false);
        沒發光物體.SetActive(true);
    }
    private void OnTriggerExit(Collider col)
    {
        //沒發光();
    }
}
