using UnityEngine;

public class MenuManager : MonoBehaviour
{
    public GameObject Cutscene_Image;
    public GameObject MainCamera;
    void Update()
    {
        MainCamera.transform.Rotate(0, Time.deltaTime * 2, 0);
    }
    public void PlayGame()
    {
        Cutscene_Image.SetActive(true);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
