using UnityEngine;
using UnityEngine.SceneManagement;

public class SettingsSwitcher : MonoBehaviour
{
    public void GotoMainScene()
    {
        SceneManager.LoadScene("GameUI");
    }

    public void GotoMenuScene()
    {
        SceneManager.LoadScene("settings");
    }
}