using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class startMenu : MonoBehaviour {
	public Canvas quitMenu;
	public Canvas aboutMenu;
	public Button startText;
	public Button exitText;
	public Button audio_on_off;
	public Button facebook;
	public Button about;
	public Button settingsText;

	


	void Start () {
		quitMenu = quitMenu.GetComponent<Canvas> ();
		startText = startText.GetComponent<Button> ();
		exitText = exitText.GetComponent<Button> ();
        quitMenu.enabled = false;
		about.enabled = false;
	}


	public void ExitPress(){

		quitMenu.enabled = true;
		startText.enabled = false;
		exitText.enabled = false;
		

		
	}


	public void Nopress() {

        quitMenu.enabled = false;
        startText.enabled = true;
        exitText.enabled = true;
		


    }
	public void StartLevel() { 
	
		SceneManager.LoadScene (3);

	
	}
	public void options_scene() { 
	
		SceneManager.LoadScene (2)
		;

	
	}

    public void ExitGame() {
		Debug.Log (quitMenu);
        Application.Quit ();
    }

	public void Facebook() {

		Application.OpenURL ("http://facebook.com");


	}

	public void Mute()
	{
		AudioListener.pause = !AudioListener.pause;


    }


}