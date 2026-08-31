using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HallCamera : MonoBehaviour
{
    public float dist;

    public AudioSource a;

    void Start()
    {
        a.volume = SaveData.音量;

        
    }

    void Update()
    {

    }
    void FixedUpdate()
    {
        if (GameObject.FindWithTag("Player") == false && GameObject.FindWithTag("P2") == true)
        {
            
            Vector3 位置 = new Vector3(GameObject.FindWithTag("P2").transform.position.x, 25, GameObject.FindWithTag("P2").transform.position.z);
            transform.position = Vector3.Lerp(transform.position, 位置, 5 * Time.deltaTime);
        }
        if (GameObject.FindWithTag("P2") == false && GameObject.FindWithTag("Player") == true)
        {
            
            Vector3 位置 = new Vector3(GameObject.FindWithTag("Player").transform.position.x, 25, GameObject.FindWithTag("Player").transform.position.z);
            transform.position = Vector3.Lerp(transform.position, 位置, 5 * Time.deltaTime);
        }
        if (GameObject.FindWithTag("Player") == true && GameObject.FindWithTag("P2") == true)
        {
            
            Vector3 位置 = new Vector3((GameObject.FindWithTag("Player").transform.position.x + GameObject.FindWithTag("P2").transform.position.x) / 2, 25, (GameObject.FindWithTag("Player").transform.position.z + GameObject.FindWithTag("P2").transform.position.z) / 2);
            transform.position = Vector3.Lerp(transform.position, 位置, 5 * Time.deltaTime);
        }
        if (GameObject.FindWithTag("Player") == false && GameObject.FindWithTag("P2") == false)
        {
            
        }
    }
}
