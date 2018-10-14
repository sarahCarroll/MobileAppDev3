using UnityEngine;
using System.Collections;

public class ObstacleController : MonoBehaviour {

    public GameObject[] challenges;
    public float scrollSpeed = 5.0f;
    public Transform obstacleSpawner;
    public float freq = 0.5f;
    float counter = 0.0f;
    bool isGameOver = false;

    // Used in initialization
    void Start () {
        CreateRandomObstacle();
	}
	
	// Update checker
	void Update () {
        if (isGameOver) return;

        //GeneratesObjects as counter reaches 0
        if (counter <= 0.0f)
        {
            CreateRandomObstacle();
        }
        else {
            counter -= Time.deltaTime * freq;
              
        }

        //Scrolling (and destroying challenges)
        GameObject childCurrent;
        for (int i = 0; i < transform.childCount; i++) {
            childCurrent = transform.GetChild(i).gameObject;
            ScrollChallenge(childCurrent);
            if (childCurrent.transform.position.x <= -30.0f) {
                Destroy(childCurrent);
            }
        }

	}

    //Scrolling the current obsticle at a speed across the screen
    void ScrollChallenge(GameObject currentObstacle) {
        currentObstacle.transform.position -= Vector3.right * (scrollSpeed * Time.deltaTime);
    }

    //using the challenges array of prefab challenges, creates new challenge at random, in the Spawn position preset.
    //created challenge is still perfectly inline with parent axis
    //sets counter to 1
    void CreateRandomObstacle() {
        GameObject newChallenge = Instantiate(challenges[Random.Range(0, challenges.Length)], obstacleSpawner.position, Quaternion.identity) as GameObject;
        newChallenge.transform.parent = transform;
        counter = 1.0f;
    }

    

    public void AdjustScrollSpeed()
    {
       scrollSpeed += 0.2f;
    }

    public void AdjustFrequency()
    {
        freq += 0.01f;
    }

    public void GameOver()
    {
        isGameOver = true;
        transform.GetComponent<GameController>().GameOver();
    }
}
