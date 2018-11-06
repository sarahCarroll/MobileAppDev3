using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//this is used to restart level if player dies
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{

    public bool hasDied;
    public int dealthLevel;
    private bool isGameOver = false;

    // Use this for initialization
    void Start()
    {
        hasDied = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (isGameOver) return;

        if (gameObject.transform.position.y < dealthLevel)
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
        
        isGameOver = true;
        //transform.GetComponent<GameController>().GameOver();
        SceneManager.LoadScene("Main");

        yield return null;
    }
}
