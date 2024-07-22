using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenu : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }
    public void ExitGame()
    {
        Application.Quit();
    }
    public void ExitToMenu()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1f;
    }
}