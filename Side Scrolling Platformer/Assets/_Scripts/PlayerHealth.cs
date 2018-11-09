using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//this is used to restart level if player dies
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{

    public bool hasDied; // boolean valiable to detemine character dead or alive
    public int dealthLevely; // the x axis point to which the character dies
    public int dealthLevelx; // the x axis point to which the character dies
    private bool isGameOver = false; // boolean detemineing game over

    // Use this for initialization
    void Start()
    {
        hasDied = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (isGameOver) return;

        if (gameObject.transform.position.y < dealthLevely || gameObject.transform.position.x < dealthLevelx)
        {
            hasDied = true;
            Debug.Log("player has died");
            Die();
        }

        if (hasDied == true)
        {
            //calls the ienumerator die
            StartCoroutine("Die");
        }
    }

    IEnumerator Die()
    {
        //yield return new WaitForSeconds(5);
        Time.timeScale = 0.0f;
        isGameOver = true;
        //transform.GetComponent<GameController>().GameOver();
        SceneManager.LoadScene("ClosingMenu");

        yield return null;
    }
}
