using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour {

    //public game pause variable set to false
    public static bool GamePause = false;

    public GameObject PauseMenu; //holds the user interface
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            //if the game is paused call resume game
            if (GamePause == true)
            {
                ResumeGame();

            }
            //otherwise pause the game
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
