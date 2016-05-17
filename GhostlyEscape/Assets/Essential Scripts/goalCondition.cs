using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class goalCondition : MonoBehaviour {

	public GameObject goalObject;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void OnCollisionEnter2D (Collision2D collision) {
		if (collision.gameObject.name == "player") {
			//Application.LoadLevel ("titleScreen");
			SceneManager.LoadScene ("winScreen");
		}
	}
}

//Reference: http://docs.unity3d.com/ScriptReference/MonoBehaviour.OnCollisionEnter2D.html