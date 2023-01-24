using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebbieDownerLauncher : MonoBehaviour
{
    [SerializeField]
    float maxX;


    [SerializeField]
    float spawnInterval;


    public GameObject[] DebbieDowners;

    public float DebbieDownerSpeed;



    public static DebbieDownerLauncher instance;


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
        StartSpawningBalls();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnBalls()
    {
        int rand = Random.Range(0, DebbieDowners.Length);

        float randomX = Random.Range(-maxX, maxX);

        Vector3 randomPos = new Vector3(randomX, transform.position.y, transform.position.z);

        GameObject BallSpawner = Instantiate(DebbieDowners[rand], randomPos, transform.rotation);


    }


    IEnumerator SpawnBallsR()
    {
        yield return new WaitForSeconds(4.2f);

        while (true)
        {
            SpawnBalls();

            yield return new WaitForSeconds(spawnInterval);

            

        }
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