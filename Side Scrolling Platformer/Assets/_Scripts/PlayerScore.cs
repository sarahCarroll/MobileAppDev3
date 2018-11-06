using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScore : MonoBehaviour {

    public Text scoreText;
    public Text highText;


    [SerializeField]
    private float elaspedTime = 0;

	// Use this for initialization
	void Start () {
        PlayerPrefs.SetInt("score", 0);
	}
	
	// Update is called once per frame
	void Update () {
        elaspedTime += Time.deltaTime;
        Debug.Log(elaspedTime);
        PlayerPrefs.SetInt("score",(int)elaspedTime);
        scoreText.text = PlayerPrefs.GetInt("score").ToString();
        Debug.Log(scoreText.text);

        if (PlayerPrefs.GetInt("score") > PlayerPrefs.GetInt("highScore"))
        {
            PlayerPrefs.SetInt("highScore", PlayerPrefs.GetInt("score"));
            highText.text = PlayerPrefs.GetInt("highScore").ToString();
        }
	}
}
