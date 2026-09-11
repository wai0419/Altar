using UnityEngine;
using UnityEngine.SceneManagement;

public class CutsceneController : MonoBehaviour
{
    public int CutsceneIndex; // 設定要跳轉的場景索引

    public void Cutscene()
    {
        SceneManager.LoadScene(CutsceneIndex);
    }
    public void Close()
    {
        gameObject.SetActive(false);
    }
}
