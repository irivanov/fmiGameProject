using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitSceneSwitcher : MonoBehaviour
{
    public void GoToExitScene()
    {
        SceneManager.LoadScene("ExitScene");
    }

    public void GameUI()
    {
        SceneManager.LoadScene("GameUI");
    }
}