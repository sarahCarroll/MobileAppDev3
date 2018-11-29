using UnityEngine;
using System.Collections;

public class ObstacleController : MonoBehaviour {

    public GameObject[] challenges; // array of platforms being procedually generated
    public float scrollSpeed ; // speed that the platforms come on screen at
    public Transform obstacleSpawner; // positions the platforms are loacted
    public float freq = 0.5f;
    float counter = 0.0f;
    bool isGameOver = false;
    int randomSpawn;
    Vector3 spawnPoint;


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
            if (childCurrent.transform.position.x <= -20.0f) {
                Destroy(childCurrent);
            }
        }

	}

    //Scrolling the current obstacle at a speed across the screen
    void ScrollChallenge(GameObject currentObstacle) {
        currentObstacle.transform.position -= Vector3.right * (scrollSpeed * Time.deltaTime);
    }

    //using the challenges array of prefab challenges, creates new challenge at random, in the Spawn position preset.
    //created challenge is still perfectly inline with parent axis
    //sets counter to 1
    void CreateRandomObstacle() {
        randomSpawn = Random.Range(-5, 5);//random number between -5 and 4  because parses down to int
        spawnPoint = obstacleSpawner.position;
        spawnPoint.y += randomSpawn;

        GameObject newChallenge = Instantiate(challenges[Random.Range(0, challenges.Length)], spawnPoint, Quaternion.identity) as GameObject;
        newChallenge.transform.parent = transform;
        counter = 1.0f;
    }

    

    public void AdjustScrollSpeed()
    {
        if (Time.deltaTime > 30.0f)
        {
            scrollSpeed += 0.5f;
        }
        if (Time.deltaTime > 60.0f)
        {
            scrollSpeed += 2.5f;
        }

    }

    public void AdjustFrequency()
    {
        if (Time.deltaTime > 30.0f)
        {
            freq += 0.5f;
        }

        if (Time.deltaTime > 60.0f)
        {
            freq += 1.5f;
        }

    }
}
