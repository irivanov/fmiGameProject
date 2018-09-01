using UnityEngine;
using UnityEngine.SceneManagement;

public class AboutSwitcher : MonoBehaviour
{
    public void GotoAboutScreen()
    {
        SceneManager.LoadScene("about");
    }

    public void BackToMainFromAbout()
    {
        SceneManager.LoadScene("GameUI");
    }
}