using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class 血條LookAT : MonoBehaviour
{
    public GameObject camera;

    // Start is called before the first frame update
    void Start()
    {

        camera = GameObject.FindWithTag("相機");
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(GameObject.FindWithTag("相機").transform.position);
        gameObject.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
    }
}
