using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class 焚化爐 : MonoBehaviour
{

    public Text 吸血鬼數量;

    public Text 幽靈數量;

    public ParticleSystem 完成特效;

    public GameObject targetEnemy;

    public GameObject 幽;

    public GameObject 生成地方;

    public GameObject 生成地方2;
    // Start is called before the first frame update
    void Start()
    {
        

        完成特效.Stop();
    }

    // Update is called once per frame
    void Update()
    {
        吸血鬼數量.text = SaveData.吸量.ToString() + "/3";
        幽靈數量.text = SaveData.幽量.ToString() + "/3";
    }
    public void 特效()
    {
        SaveData.EnemyCounter=1;
        完成特效.Play();
        Invoke("erogjeogj", 2f);
        SaveData.吸量 += 1;
        吸血鬼數量.text = SaveData.吸量.ToString()+"/3";

        Instantiate(targetEnemy, 生成地方2.transform.position, Quaternion.identity);
    }

    public void 幽靈特效()
    {
        SaveData.生幽=1;
        完成特效.Play();
        Invoke("erogjeogj", 2f);
        SaveData.幽量 += 1;
        幽靈數量.text = SaveData.幽量.ToString() + "/3";

        Instantiate(幽, 生成地方.transform.position, Quaternion.identity);
    }
    void erogjeogj()
    {
        完成特效.Stop();
    }
}
