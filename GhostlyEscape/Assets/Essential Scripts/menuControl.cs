using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class menuControl : MonoBehaviour {
	
	public Button startText;
	public Button exitText;

	// Use this for initialization
	void Start () {
		startText = startText.GetComponent<Button> ();
		exitText = exitText.GetComponent<Button> ();
	}

	// This code is used to confirm that the start button is not active while the exit button is exit
	public void ExitPress() {
		startText.enabled = false;
		exitText.enabled = true;
	}

	// This code is used to confirm that both the start and exit buttons in the menu screen isn't activated since none of them are being clicked on.
	public void NoPress() {
		startText.enabled = false;
		exitText.enabled = false;
	}

	// This code is used to load the level if and only if the start game button text is used.
	public void StartLevel(){
		SceneManager.LoadScene ("prototype");

	}

	// This code is used to confirm that pressing the exit button will cause the game to close (WON'T work on Web Player version of game!!!)
	public void ExitGame(){
		Application.Quit ();
	}
}

//References
//https://www.youtube.com/watch?v=pT4uca2bSgc