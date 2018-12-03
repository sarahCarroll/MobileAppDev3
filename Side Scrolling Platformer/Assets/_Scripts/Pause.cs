using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour {

    public static bool GamePause = false;

    public GameObject PauseMenu; //holds the user interface



	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GamePause == true)
            {
                ResumeGame();

            }
            else
                PauseGame();
        }
		
	}

    public void PauseGame()
    {
        //when pause want to set the pauseGame = true
        PauseMenu.SetActive(true);
        Debug.Log("teest");
        Time.timeScale = 0.0f;// stopping time
        GamePause = true;
    }

    public void ResumeGame()
    {
        PauseMenu.SetActive(false);
        Time.timeScale = 1.0f;
        GamePause = false;
    }
}
