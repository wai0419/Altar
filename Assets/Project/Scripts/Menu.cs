using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.InputSystem;

public class Menu : MonoBehaviour
{
    public GameObject 跳轉;
    public GameObject 第一頁;
    public GameObject 第二頁;

    void Update()
    {   
        第一頁設定();     
    }
    public void PlayGame()
    {
        跳轉.SetActive(true);
        
        Invoke("跳", 2f);

    }
    void 跳()
    {
        SceneManager.LoadScene(1);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    
    public void 第一頁設定()
    {

    }


    IEnumerator PlayHaptics(float seconds)
    {
        Gamepad.all[1].SetMotorSpeeds(.25f,.75f);
        yield return new WaitForSeconds(seconds);
        InputSystem.ResetHaptics();
    }
}
