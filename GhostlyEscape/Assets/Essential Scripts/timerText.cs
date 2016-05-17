using UnityEngine;
using System.Collections;

public class timerText : MonoBehaviour {

	public GameObject timeText;
	float timeLeft = 500f;

	// Use this for initialization
	void Start () {
		timeText.GetComponent<TextMesh> ().color = Color.white; // Sets up the color for the timer Text
		timeText.GetComponent<TextMesh> ().text = "Timer: " + timeLeft; //Sets up the variables for the game's Timer 
	}
	
	// Update is called once per frame
	void Update () {
		timeText.GetComponent<TextMesh> ().color = Color.white;
		timeText.GetComponent<TextMesh> ().text = "Timer: " + Mathf.Round(timeLeft);
		timeLeft -= Time.deltaTime;
		if (timeLeft == 0) {
			Application.LoadLevel ("gameOver");
	}
}
}