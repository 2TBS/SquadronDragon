using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MM_Menu : MonoBehaviour {
    int level = 1;
	Text scoreLabel;
	// Use this for initialization
	void Start () {
		if (SceneManager.GetActiveScene ().name == "GameOver") {
			scoreLabel = GetComponent<UnityEngine.UI.Text> ();
			scoreLabel.text = "Your Score Is: " + PL_Score.score.ToString();
			UnityEditor.EditorUtility.SetDirty(scoreLabel);
			Canvas.ForceUpdateCanvases();
			scoreLabel.SetAllDirty ();
			scoreLabel.UpdateText ();
			Debug.Log (PL_Score.score.ToString ());
			Debug.Log (scoreLabel);
		}
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
