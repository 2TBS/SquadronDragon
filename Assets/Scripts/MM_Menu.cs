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
		
	}

	public void LoadScene() {
		SceneManager.LoadScene(level);
	}
    public void BackScene()
    {
        SceneManager.LoadScene(level-1);
        level--;
    }
	public void ForwardScene()
	{
		SceneManager.LoadScene(level+1);
		level++;
	}
    public void GameOver()
    {
        level = 0;
        SceneManager.LoadScene(level);
    }
}
