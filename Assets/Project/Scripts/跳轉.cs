using UnityEngine;
using UnityEngine.SceneManagement;

public class 跳轉 : MonoBehaviour
{
    public Animator 動畫控制器;
    
    public int CutsceneIndex; // 設定要跳轉的場景索引
    void Start()
    {
        動畫控制器 = GetComponent<Animator>();
    }

    public void Cutscence()
    {
        SceneManager.LoadScene(CutsceneIndex);
    }
}
