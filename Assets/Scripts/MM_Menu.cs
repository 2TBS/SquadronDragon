using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MM_Menu : MonoBehaviour {
    int level = 1;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.Escape)) {
			//Exit if Esc key pressed
			Application.Quit();
		}
	}

	public void LoadScene() {
		SceneManager.LoadScene(level);
        level++;
	}
    public void BackScene()
    {
        level--;
        SceneManager.LoadScene(level);
        level--;
    }
    public void GameOver()
    {
        level = 0;
        SceneManager.LoadScene(0);
    }
	public void ExitGame() 
	{
		Application.Quit();
	}
}
