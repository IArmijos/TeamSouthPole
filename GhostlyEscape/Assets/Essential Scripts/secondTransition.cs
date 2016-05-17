using UnityEngine;
using System.Collections;

public class secondTransition : MonoBehaviour {

	public GameObject startText;

	// Use this for initialization
	void Start () {

	}
		

	// This code is used to load the level if and only if the start game button text is used.
	public void StartLevel(){
		Application.LoadLevel ("prototype");

	}

	// This code is used to confirm that pressing the exit button will cause the game to close (WON'T work on Web Player version of game!!!)
	public void ExitGame(){
		Application.Quit ();
		}
	}

//References
//https://www.youtube.com/watch?v=pT4uca2bSgc