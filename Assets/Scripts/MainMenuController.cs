using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenuController : MonoBehaviour
{
    
    public void GoToLevel()
    {
        SceneManager.LoadScene("Level1");
    }
    
    public void GoToHome()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void Quit()
    {
        Application.Quit();
    }
}
