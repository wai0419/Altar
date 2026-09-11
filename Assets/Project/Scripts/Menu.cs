using UnityEngine;

public class Menu : MonoBehaviour
{
    public GameObject Cutscene_Image;

    public void PlayGame()
    {
        Cutscene_Image.SetActive(true);
    }
    public void QuitGame()
    {
        Application.Quit();
    } 
}
