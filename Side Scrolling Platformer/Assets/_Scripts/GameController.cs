using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameController : MonoBehaviour {
    
    public GameObject gameOverPanel;
    public Text textScore;
    int total = 0;
    public Text textBest;
    public Text textCurrent;
    public GameObject newScore;
    ObstacleController myObstacleController;

    // Used in initialization
    void Start () {
        myObstacleController = GameObject.FindObjectOfType<ObstacleController>();
    }
	
	// Update is called once per frame
	void Update () {
	
	}
    //Using the ShowOverPanel 
    public void GameOver() {
        Invoke("ShowOverPanel", 2.0f);
    }

    //determining new and best score and your score and
    //prints them to GameOverPanel canvas in Unity
   
    void ShowOverPanel() {
        textScore.gameObject.SetActive(false);

        if (total > PlayerPrefs.GetInt("Best", 0))
        {
            PlayerPrefs.SetInt("Best", total);
            newScore.SetActive(true);
        }

        textBest.text = "Best Score : " + PlayerPrefs.GetInt("Best", 0).ToString();
        textCurrent.text = "Your Score : " + total.ToString();

        gameOverPanel.SetActive(true);
    }
    //Restart using the Fader
    /*public void Restart() {
        Initiate.Fade(Application.loadedLevelName,Color.white,2.0f);
    }*/

    public void IncrementScore() {
        total++;
        textScore.text = total.ToString();
        if (total < 35)
        {
            myObstacleController.AdjustScrollSpeed();
            myObstacleController.AdjustFrequency();
        }
    }
}
