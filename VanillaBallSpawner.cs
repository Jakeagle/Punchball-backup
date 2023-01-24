using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VanillaBallSpawner : MonoBehaviour
{
    [SerializeField]
    float maxX;


    [SerializeField]
    float spawnInterval;


    public GameObject[] Balls;

    public float BallSpeed;

    public int ballCount;

    public static VanillaBallSpawner instance;

    int inspawningBallsCount = 0;
    int maxBallCount = 5;



    private void Awake()
    {

        if (instance == null)
        {
            instance = this;
        }
    }



    // Start is called before the first frame update
    void Start()
    {

       
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.FindGameObjectsWithTag("Clone").Length + inspawningBallsCount < maxBallCount)
        {

            StartCoroutine("SpawnBallsR");
            inspawningBallsCount += 1;
        }

    }

    void SpawnBalls()
    {
        int rand = Random.Range(0, Balls.Length);

        float randomX = Random.Range(-maxX, maxX);

        Vector3 randomPos = new Vector3(randomX, transform.position.y, transform.position.z);

        GameObject BallSpawner = Instantiate(Balls[rand], randomPos, transform.rotation);


    }


    IEnumerator SpawnBallsR()
    {
        yield return new WaitForSeconds(2f);

            SpawnBalls();
            inspawningBallsCount -= 1;

    }

    public void StartSpawningBalls()
    {
        StartCoroutine("SpawnBallsR");
    }

    public void StopSpawningBalls()
    {
        StopCoroutine("SpawnBallsR");
    }



}

