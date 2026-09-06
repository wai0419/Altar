using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class 調音量 : MonoBehaviour
{
    [SerializeField] private Slider _slider;


    public AudioSource a;
    // Start is called before the first frame update
    void Start()
    {
        _slider.value = 1f;

            _slider.onValueChanged.AddListener((V) =>
            {
                a.volume = (V / 10) * 3;
                
                SaveData.音量 = (V/10)*3;
                Debug.Log(SaveData.音量);
            });
    }

}
