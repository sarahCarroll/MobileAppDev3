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

    private void OnTriggerEnter2D(Collider2D Enemy)
    {
        if (GameObject.FindWithTag("enemy"))
        {
            // PlayerPrefs.SetInt("score") -= 5f;
            Debug.LogWarning("enemy hit");
            Destroy(GameObject.FindWithTag("enemy"));
        }
        //Destroy(transform.gameObject);
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
